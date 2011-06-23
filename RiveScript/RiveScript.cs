
using System;

namespace RiveScript
{


	public class RiveScript
	{

		public RiveScript ()
		{
		}
		
		#region [ Debug ]
		public void Debug(String message)
		{
		}
		
		public void Issue(String message)
		{
			
		}
		
		#endregion
		
		#region [ File/Directory work ]
		
		public bool LoadDirectory(String path)
		{
			return true; // if load with success
		}
		
		public bool LoadFile(String filename)
		{
			return true; // if load with success
		}
		
		public bool Stream(String code)
		{
			return true; // if load with success
		}
		
		#endregion
		
		#region [ Parsing methods ]
		
		public void Parse(String fname, String code)
		{
		}
		
		public void CheckSyntax(String command, String line)
		{	
			// if line has a problem
			throw new Exception("This is a error in line N: Message of hell!");
		}
		
		public void SortReplies()
		{
			//TODO: need some instruction to sort boot replies
		}
		
		#endregion
		
		#region [ Configuration Methods ]
		
		public void SetHandler(Hashtable information)
		{
			
		}
		
		public void SetSubrotine(String name, String code)
		{
		}
		
		public void SetVariables(Hashtable data)
		{
		}
		
	}
}
