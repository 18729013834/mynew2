using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MetaShare.Common.Core.Entities;
/*add customized code between this region*/
Public string Name {get;set;}
/*add customized code between this region*/

namespace yuhs.Entities.src
{
	public class student : MetaShare.Common.Core.Entities.Common
	{
		[DataMember]
		public int studentnumber{get; set;}
		
		[DataMember]
		public string studentname{get; set;}
		
		/*add customized code between this region*/
  Public string Name {get;set;}
		/*add customized code between this region*/
	}
}
