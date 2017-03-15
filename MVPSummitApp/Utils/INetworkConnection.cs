using System;
namespace MVPSummitApp
{
	public interface INetworkConnection
	{
		bool IsConnected { get; }
		void CheckNetworkConnection();
	}
}
