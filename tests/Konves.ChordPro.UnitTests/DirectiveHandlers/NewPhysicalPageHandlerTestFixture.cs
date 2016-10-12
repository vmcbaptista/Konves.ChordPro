﻿using Konves.ChordPro.DirectiveHandlers;
using Konves.ChordPro.Directives;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Konves.ChordPro.UnitTests.DirectiveHandlers
{
	[TestClass]
	public class NewPhysicalPageHandlerTestFixture : KeyOnlyBaseTestFixture<NewPhysicalPageDirective>
	{
		public NewPhysicalPageHandlerTestFixture() : base("{new_physical_page}", "{npp}", NewPhysicalPageHandler.Instance) { }

		[TestMethod]
		public override void TryParseTest_LongForm() { base.TryParseTest_LongForm(); }

		[TestMethod]
		public override void TryParseTest_ShortForm() { base.TryParseTest_ShortForm(); }

		[TestMethod]
		public override void GetStringTest_LongForm() { base.GetStringTest_LongForm(); }

		[TestMethod]
		public override void GetStringTest_ShortForm() { base.GetStringTest_ShortForm(); }
	}
}