using System;
using System.Data;
using System.Data.Odbc;
using System.Collections;

namespace C_DentalClaimTracker
{
	
	/// <summary>
	/// Manages all active and non-active SQL connections.
	/// </summary>
	public class ConnectionHandler
	{
		private ConnectionHolderCollection _conPool;		
		
		public ConnectionHandler()
		{
			_conPool = new ConnectionHolderCollection();			
		}		
		
		public void CloseAll()
		{
			// Release all active connections
			for (int i = 0;i < ConnectionPool.Count;i++)
			{
				ConnectionPool[i].Connection.Close();
			}
		}

		public ConnectionHolderCollection ConnectionPool
		{
			get { return _conPool; }
		}

		public ConnectionHolder AddConnection(ConnectionAlias alias)
		{
			OdbcConnection newConnection;
			
            /*
			for (int i = 0;i < ConnectionPool.Count;i++)
			{
				if (alias.CompareToConnection(ConnectionPool[i].Connection))
				{
					// This connection already exists
					if (ConnectionPool[i].Status == ConnectionHolderStatus.Active)
					{
						// This connection is currently in use by another object
						// So create an identical connection instead
					}
				}					
			}
             */

			newConnection = new OdbcConnection(alias.GetConnectionString());
			
			try 
			{
				newConnection.Open();							
			}
			catch (Exception err)
			{
                LoggingHelper.Log("Error in ConnectionHandler.AddConnection", LogSeverity.Error, err, false);
				throw new Exception("The connection test for the newly added connection failed.",err);
			}
			// Connection test succeeded
			ConnectionHolder newConnHold = new ConnectionHolder(newConnection,null);
			ConnectionPool.Add(newConnHold);

            return newConnHold;
		}

		public void AddConnection(ConnectionAlias alias, bool persistent)
		{
			OdbcConnection newConnection;
			
			for (int i = 0;i < ConnectionPool.Count;i++)
			{
				if (alias.CompareToConnection(ConnectionPool[i].Connection))
				{
					// This connection already exists
					if (ConnectionPool[i].Status == ConnectionHolderStatus.Active)
					{
						// This connection is currently in use by another object
						// So create an identical connection instead
					}
				}					
			}

			newConnection = new OdbcConnection(alias.GetConnectionString());
			
			try 
			{
				newConnection.Open();
				
				if (!persistent)
					newConnection.Close();								
			}
			catch (Exception err)
			{
                LoggingHelper.Log("Error in ConnectionHandler.AddConnection", LogSeverity.Error, err, false);
				throw new Exception("The connection test for the newly added connection failed.",err);
			}
			// Connection test succeeded
			ConnectionHolder newConnHold = new ConnectionHolder(newConnection,null);
			newConnHold.PersistentConnection = persistent;
			ConnectionPool.Add(newConnHold);	
		}
		
		public void RemoveConnection(ConnectionAlias alias)
		{			
			for (int i = 0;i < ConnectionPool.Count;i++)
			{
				if (alias.CompareToConnection(ConnectionPool[i].Connection))
				{
					ConnectionPool.RemoveAt(i);					
					break;
				}
			}
		}
		
		public OdbcConnection RequestConnection(ConnectionAlias alias, object obj)
		{
            return AddConnection(alias).Connection;
			// Check connections
            /*
            for (int i = 0; i < ConnectionPool.Count; i++)
            {
                try
                {
                    if (alias.CompareToConnection(ConnectionPool[i].Connection))
                    {

                        if (ConnectionPool[i].Status != ConnectionHolderStatus.Active)
                        {
                            ConnectionHolder ch = ConnectionPool[i];
                            ch.ParentObject = obj;

                            if (ch.Status == ConnectionHolderStatus.Closed)
                                ch.Connection.Open();

                            return ch.Connection;
                        }
                    }
                }

                catch (Exception err)
                {
                    // Log if not an invalid index, connection pool was modified during search...ignore and allow it to get a new connection
                    if (i <= ConnectionPool.Count)
                    {
                        LoggingHelper.Log("Error requesting connection in ConnectionHandler.RequestConnection. i = " + i + " Count = " + ConnectionPool.Count, LogSeverity.Error, err, false);
                    }
                    break;
                }
            }
             */
			
			// Connection could not be found, add it
			
			// return RequestConnection(alias, obj);
		}
		
		public void ReleaseConnection(object obj, OdbcConnection connection)
		{
            connection.Close();
            /*
			bool foundDup = false;
            
			for (int i = 0;i < ConnectionPool.Count;i++)
			{
				if (ConnectionPool[i].Connection == connection)
				{
					if (ConnectionPool[i].ParentObject == obj)
					{
						
						for (int c = 0;c < ConnectionPool.Count;c++)
						{
							if ((ConnectionPool[i].Alias.CompareToConnection(ConnectionPool[c].Connection)) &&
								(ConnectionPool[i] != ConnectionPool[c]))
							{
								// Found a duplicate connection
								foundDup = true;								
								break;
							}
						}						

						if (foundDup)
						{
							// Found a duplicate connection, this means that this was only a temp connection
							// So it is ok to remove it now
							ConnectionPool.RemoveAt(i);
						}
						else
						{
							// No duplicates found, this is the only connection of this type
							if (ConnectionPool[i].PersistentConnection)
							{
								if (ConnectionPool[i].Status == ConnectionHolderStatus.Closed)
									ConnectionPool[i].Connection.Open();
							}
							else
							{
								if (ConnectionPool[i].Status != ConnectionHolderStatus.Closed)
									ConnectionPool[i].Connection.Close();
							}

                            ConnectionPool[i].ParentObject = null;
						}

                        
					}
				}
             
			}
             */
        }		
		
		/// <summary>
		/// Collection of Connection Holder objects.
		/// </summary>
		public class ConnectionHolderCollection : System.Collections.CollectionBase
		{
			public ConnectionHolderCollection()
			{}

			public void Add(ConnectionHolder connection)
			{
				List.Add(connection);
			}

			public void Remove(ConnectionHolder connection)
			{
				if (connection != null)
					List.Remove(connection);
			}

			public void Remove(int index)
			{
				if (index > Count - 1 || index < 0)
				{
                    LoggingHelper.Log("Programmer Error in ConnectionHolderCollection.Remove - Index not valid.", LogSeverity.Error);
					throw new Exception("Index not valid!");
				}
				else
				{
					List.RemoveAt(index);
				}
			}

			public ConnectionHolder this[int index]
			{
				get 
				{
					return (ConnectionHolder) List[index];				
				}
			}
		}
	}	
	
	public enum ConnectionHolderStatus
	{
		Active,
		Closed,
		Idle
	}

	public class ConnectionHolder
	{
		private OdbcConnection _thisConnection;
		private ConnectionAlias _thisAlias;
		private object _parent; 		
		private bool _persistent;

		/// <summary>
		/// Creates an instance of a ConnectionHolder object.
		/// </summary>
		/// <param name="connection">This is the actual connection object assigned.</param>
		/// <param name="parent">The object that will be attached to this connection. For example, the data object that is requesting it.</param>
		public ConnectionHolder(OdbcConnection connection, object parent)
		{
			_thisConnection = connection;
			_thisAlias = new ConnectionAlias();
			_parent = parent;
			_persistent = false;
		}

		public ConnectionHolder(OdbcConnection connection, object parent, ConnectionAlias alias)
		{
			_thisConnection = connection;
			_thisAlias = alias;
			_parent = parent;
			_persistent = false;
		}
		
		public bool PersistentConnection
		{
			get { return _persistent; }
			set { _persistent = true; }
		}

		public OdbcConnection Connection
		{
			get { return _thisConnection; }
		}

		public object ParentObject
		{
			get { return _parent; }
			set { _parent = value; }
		}

		public ConnectionHolderStatus Status
		{
			get 
			{ 
                if (_parent != null)
                    return ConnectionHolderStatus.Active;
                if (_thisConnection.State == ConnectionState.Closed)
                    return ConnectionHolderStatus.Closed;
                else if (_thisConnection.State == ConnectionState.Connecting)
                    return ConnectionHolderStatus.Active;

                return ConnectionHolderStatus.Idle;
                
			}
		}

		public ConnectionAlias Alias
		{
			get { return _thisAlias; }
		}
	}
	
}
