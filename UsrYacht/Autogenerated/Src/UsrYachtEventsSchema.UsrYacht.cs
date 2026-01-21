namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventsSchema

	/// <exclude/>
	public class UsrYachtEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventsSchema(UsrYachtEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("76759409-3e73-42e5-8e71-d8ed5d353f56");
			Name = "UsrYachtEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b15b5be0-4758-439f-845c-3b88ec1b4447");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,219,106,219,64,16,134,239,5,125,135,65,87,18,152,165,185,173,219,64,109,220,18,8,109,169,149,66,40,189,88,175,198,242,150,61,136,157,149,83,183,248,221,187,7,199,181,236,132,116,64,32,205,254,251,205,252,163,49,92,35,245,92,32,52,232,28,39,187,246,108,110,205,90,118,131,227,94,90,83,252,41,32,196,64,210,116,176,220,145,71,61,61,201,156,222,210,218,154,231,206,28,178,133,241,210,75,164,255,144,176,197,22,141,63,40,191,167,236,46,165,110,101,104,192,160,171,150,98,131,154,127,10,221,195,59,40,239,200,221,115,177,241,101,253,35,93,233,135,149,146,2,132,226,68,144,78,158,96,192,27,152,113,194,39,78,18,35,251,62,161,217,109,104,86,182,8,91,43,91,248,108,150,124,27,44,84,118,245,19,133,7,66,211,162,155,64,198,205,112,29,252,36,232,123,215,17,96,125,164,253,227,198,88,133,14,216,145,245,8,193,122,58,82,101,40,236,162,147,224,183,202,223,117,150,143,165,45,10,169,185,130,222,73,17,103,147,238,176,143,232,155,93,143,237,220,170,65,155,111,92,13,248,246,160,188,174,226,248,190,68,121,121,86,86,174,161,202,156,107,184,122,157,162,30,9,198,94,98,32,187,161,57,55,2,21,182,161,186,119,3,78,139,11,21,121,23,255,126,88,61,226,29,54,168,123,197,125,236,214,224,3,220,90,193,149,252,205,87,10,151,73,87,101,15,119,132,46,172,166,9,211,14,123,201,190,34,217,193,137,160,177,46,64,38,175,46,170,196,56,174,70,222,168,114,2,229,5,159,88,26,200,13,53,214,206,100,151,191,202,154,53,246,80,191,126,209,66,104,61,39,216,7,235,52,247,213,153,181,80,246,10,194,248,226,115,62,229,24,126,227,236,67,114,191,248,37,176,143,6,31,17,103,234,125,49,126,219,23,251,226,47,77,63,184,211,197,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4ec68bb7-03a1-79fe-2f70-4f9945d40e34"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("b15b5be0-4758-439f-845c-3b88ec1b4447"),
				CreatedInSchemaUId = new Guid("76759409-3e73-42e5-8e71-d8ed5d353f56"),
				ModifiedInSchemaUId = new Guid("76759409-3e73-42e5-8e71-d8ed5d353f56")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("76759409-3e73-42e5-8e71-d8ed5d353f56"));
		}

		#endregion

	}

	#endregion

}

