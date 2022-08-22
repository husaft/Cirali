using System.Collections.Generic;
using System.Xml.Serialization;

namespace Auto
{
	[XmlRoot("CIRALI")]
	public class CIRALI
	{
		[XmlElement("CONTROLLER")]
		public Cirali.CONTROLLER CONTROLLER { get; set; }

		[XmlElement("FORMINFO")]
		public Cirali.FORMINFO FORMINFO { get; set; }

		[XmlElement("OBJECTS")]
		public Cirali.OBJECTS OBJECTS { get; set; }

		[XmlElement("RESOURCES")]
		public Cirali.RESOURCES RESOURCES { get; set; }

		[XmlElement("WORKFLOW")]
		public Cirali.WORKFLOW WORKFLOW { get; set; }

		[XmlAttribute("changeProg")]
		public string ChangeProg { get; set; }

		[XmlAttribute("changeTime")]
		public string ChangeTime { get; set; }

		[XmlAttribute("version")]
		public string Version { get; set; }
	}
}

namespace Auto.Cirali
{
	[XmlRoot("OBJECTS")]
	public class OBJECTS
	{
		[XmlElement("BUTTON")]
		public Objects.BUTTON BUTTON { get; set; }

		[XmlElement("CHECKBOX")]
		public Objects.CHECKBOX CHECKBOX { get; set; }

		[XmlElement("CONTAINER")]
		public Objects.CONTAINER CONTAINER { get; set; }

		[XmlElement("DROPDOWN")]
		public Objects.DROPDOWN DROPDOWN { get; set; }

		[XmlElement("FRAME")]
		public Objects.FRAME FRAME { get; set; }

		[XmlElement("HOTSPOT")]
		public Objects.HOTSPOT HOTSPOT { get; set; }

		[XmlElement("IMAGE")]
		public Objects.IMAGE IMAGE { get; set; }

		[XmlElement("INFO")]
		public Objects.INFO INFO { get; set; }

		[XmlElement("LINE")]
		public Objects.LINE LINE { get; set; }

		[XmlElement("RECTANGLE")]
		public Objects.RECTANGLE RECTANGLE { get; set; }

		[XmlElement("TEXT")]
		public Objects.TEXT TEXT { get; set; }

		[XmlElement("TEXTAREA")]
		public Objects.TEXTAREA TEXTAREA { get; set; }

		[XmlElement("TEXTCLUSTER")]
		public Objects.TEXTCLUSTER TEXTCLUSTER { get; set; }

		[XmlElement("TEXTFIELD")]
		public Objects.TEXTFIELD TEXTFIELD { get; set; }

		[XmlAttribute("maxBTN")]
		public byte MaxBTN { get; set; }

		[XmlAttribute("maxCHB")]
		public byte MaxCHB { get; set; }

		[XmlAttribute("maxCNT")]
		public byte MaxCNT { get; set; }

		[XmlAttribute("maxDRD")]
		public byte MaxDRD { get; set; }

		[XmlAttribute("maxFRM")]
		public byte MaxFRM { get; set; }

		[XmlAttribute("maxFSG")]
		public byte MaxFSG { get; set; }

		[XmlAttribute("maxHTS")]
		public byte MaxHTS { get; set; }

		[XmlAttribute("maxIMG")]
		public byte MaxIMG { get; set; }

		[XmlAttribute("maxINF")]
		public byte MaxINF { get; set; }

		[XmlAttribute("maxLIN")]
		public byte MaxLIN { get; set; }

		[XmlAttribute("maxRTA")]
		public byte MaxRTA { get; set; }

		[XmlAttribute("maxTXA")]
		public byte MaxTXA { get; set; }

		[XmlAttribute("maxTXC")]
		public byte MaxTXC { get; set; }

		[XmlAttribute("maxTXF")]
		public byte MaxTXF { get; set; }

		[XmlAttribute("maxTXT")]
		public byte MaxTXT { get; set; }

		[XmlAttribute("maxULG")]
		public byte MaxULG { get; set; }
	}

	[XmlRoot("RESOURCES")]
	public class RESOURCES
	{
		[XmlElement("CHECKBOX")]
		public Objects.CHECKBOX CHECKBOX { get; set; }

		[XmlElement("DROPDOWN")]
		public Objects.DROPDOWN DROPDOWN { get; set; }

		[XmlElement("FRAME")]
		public Objects.FRAME FRAME { get; set; }

		[XmlElement("IMAGE")]
		public Objects.IMAGE IMAGE { get; set; }

		[XmlElement("INFO")]
		public Objects.INFO INFO { get; set; }

		[XmlElement("LINE")]
		public Objects.LINE LINE { get; set; }

		[XmlElement("RECTANGLE")]
		public Objects.RECTANGLE RECTANGLE { get; set; }

		[XmlElement("TEXT")]
		public Objects.TEXT TEXT { get; set; }

		[XmlElement("TEXTAREA")]
		public Objects.TEXTAREA TEXTAREA { get; set; }

		[XmlElement("TEXTCLUSTER")]
		public Objects.TEXTCLUSTER TEXTCLUSTER { get; set; }

		[XmlElement("TEXTFIELD")]
		public Objects.TEXTFIELD TEXTFIELD { get; set; }
	}
	
	[XmlRoot("WORKFLOW")]
	public class WORKFLOW
	{
		[XmlElement("ATTACHMENTS")]
		public Workflow.ATTACHMENTS ATTACHMENTS { get; set; }

		[XmlElement("TRANSPONDER")]
		public Workflow.TRANSPONDER TRANSPONDER { get; set; }
	}
	
	[XmlRoot("CONTROLLER")]
	public class CONTROLLER
	{
		[XmlElement("CODE")]
		public string CODE { get; set; }

		[XmlElement("SOURCECODEFILENAME")]
		public string SOURCECODEFILENAME { get; set; }

		[XmlElement("SOURCECODE")]
		public Controller.SOURCECODE SOURCECODE { get; set; }
	}
	
	[XmlRoot("FORMINFO")]
	public class FORMINFO
	{
		[XmlElement("PAGESIGMA")]
		public byte PAGESIGMA { get; set; }

		[XmlElement("BACKGROUND")]
		public Forminfo.BACKGROUND BACKGROUND { get; set; }

		[XmlElement("CONTROL")]
		public Forminfo.CONTROL CONTROL { get; set; }

		[XmlElement("EDITOR")]
		public Forminfo.EDITOR EDITOR { get; set; }

		[XmlElement("FORMSERVER")]
		public Forminfo.FORMSERVER FORMSERVER { get; set; }

		[XmlElement("OPTIONS")]
		public Forminfo.OPTIONS OPTIONS { get; set; }

		[XmlElement("PAGESIZE")]
		public Forminfo.PAGESIZE PAGESIZE { get; set; }

		[XmlElement("TAGS")]
		public Forminfo.TAGS TAGS { get; set; }
	}
}

namespace Auto.Cirali.Controller
{
	[XmlRoot("SOURCECODE")]
	public class SOURCECODE
	{
		[XmlText]
		public string Text { get; set; }

		[XmlAttribute("decodedlength")]
		public ushort Decodedlength { get; set; }
	}
}

namespace Auto.Cirali.Forminfo.Editor
{
	[XmlRoot("COPYOFFSET")]
	public class COPYOFFSET
	{
		[XmlAttribute("x")]
		public string X { get; set; }

		[XmlAttribute("y")]
		public string Y { get; set; }
	}

	[XmlRoot("RASTERCOLOR")]
	public class RASTERCOLOR
	{
		[XmlAttribute("blue")]
		public byte Blue { get; set; }

		[XmlAttribute("green")]
		public byte Green { get; set; }

		[XmlAttribute("red")]
		public byte Red { get; set; }
	}

	[XmlRoot("RULER")]
	public class RULER
	{
		[XmlAttribute("blue")]
		public byte Blue { get; set; }

		[XmlAttribute("bmargin")]
		public string Bmargin { get; set; }

		[XmlAttribute("duplexoffset")]
		public string Duplexoffset { get; set; }

		[XmlAttribute("green")]
		public byte Green { get; set; }

		[XmlAttribute("h10y")]
		public string H10y { get; set; }

		[XmlAttribute("h1y")]
		public string H1y { get; set; }

		[XmlAttribute("h2y")]
		public string H2y { get; set; }

		[XmlAttribute("h3y")]
		public string H3y { get; set; }

		[XmlAttribute("h4y")]
		public string H4y { get; set; }

		[XmlAttribute("h5y")]
		public string H5y { get; set; }

		[XmlAttribute("h6y")]
		public string H6y { get; set; }

		[XmlAttribute("h7y")]
		public string H7y { get; set; }

		[XmlAttribute("h8y")]
		public string H8y { get; set; }

		[XmlAttribute("h9y")]
		public string H9y { get; set; }

		[XmlAttribute("lmargin")]
		public string Lmargin { get; set; }

		[XmlAttribute("red")]
		public byte Red { get; set; }

		[XmlAttribute("rmargin")]
		public string Rmargin { get; set; }

		[XmlAttribute("tmargin")]
		public string Tmargin { get; set; }

		[XmlAttribute("v10x")]
		public string V10x { get; set; }

		[XmlAttribute("v1x")]
		public string V1x { get; set; }

		[XmlAttribute("v2x")]
		public string V2x { get; set; }

		[XmlAttribute("v3x")]
		public string V3x { get; set; }

		[XmlAttribute("v4x")]
		public string V4x { get; set; }

		[XmlAttribute("v5x")]
		public string V5x { get; set; }

		[XmlAttribute("v6x")]
		public string V6x { get; set; }

		[XmlAttribute("v7x")]
		public string V7x { get; set; }

		[XmlAttribute("v8x")]
		public string V8x { get; set; }

		[XmlAttribute("v9x")]
		public string V9x { get; set; }
	}
	
	[XmlRoot("SNAPCOLOR")]
	public class SNAPCOLOR
	{
		[XmlAttribute("blue")]
		public byte Blue { get; set; }

		[XmlAttribute("green")]
		public byte Green { get; set; }

		[XmlAttribute("red")]
		public byte Red { get; set; }
	}
}

namespace Auto.Cirali.Forminfo
{
	[XmlRoot("BACKGROUND")]
	public class BACKGROUND
	{
		[XmlAttribute("blue")]
		public byte Blue { get; set; }

		[XmlAttribute("green")]
		public byte Green { get; set; }

		[XmlAttribute("red")]
		public byte Red { get; set; }
	}
	
	[XmlRoot("CONTROL")]
	public class CONTROL
	{
		[XmlElement("ENCRYPT")]
		public byte ENCRYPT { get; set; }
	}

	[XmlRoot("EDITOR")]
	public class EDITOR
	{
		[XmlElement("SNAPSIZE")]
		public string SNAPSIZE { get; set; }

		[XmlElement("COPYOFFSET")]
		public Editor.COPYOFFSET COPYOFFSET { get; set; }

		[XmlElement("RASTERCOLOR")]
		public Editor.RASTERCOLOR RASTERCOLOR { get; set; }

		[XmlElement("RULER")]
		public Editor.RULER RULER { get; set; }

		[XmlElement("SNAPCOLOR")]
		public Editor.SNAPCOLOR SNAPCOLOR { get; set; }

		[XmlAttribute("label")]
		public string Label { get; set; }

		[XmlAttribute("version")]
		public string Version { get; set; }
	}

	[XmlRoot("FORMSERVER")]
	public class FORMSERVER
	{
		[XmlElement("COPYRIGHT")]
		public string COPYRIGHT { get; set; }

		[XmlElement("CURLAYOUTHC")]
		public string CURLAYOUTHC { get; set; }

		[XmlElement("FORMID")]
		public ushort FORMID { get; set; }

		[XmlElement("FORMNAME")]
		public string FORMNAME { get; set; }

		[XmlElement("FORMTIME")]
		public string FORMTIME { get; set; }

		[XmlElement("FORMUID")]
		public string FORMUID { get; set; }

		[XmlElement("FORMVERSION")]
		public byte FORMVERSION { get; set; }

		[XmlElement("HREF")]
		public string HREF { get; set; }

		[XmlElement("INSTITUTE")]
		public string INSTITUTE { get; set; }

		[XmlElement("MANDANTID")]
		public byte MANDANTID { get; set; }

		[XmlElement("MANDANTUID")]
		public string MANDANTUID { get; set; }

		[XmlElement("PHYSNAME")]
		public string PHYSNAME { get; set; }

		[XmlElement("PRODID")]
		public string PRODID { get; set; }

		[XmlElement("UID")]
		public byte UID { get; set; }
	}

	[XmlRoot("OPTIONS")]
	public class OPTIONS
	{
		[XmlAttribute("addfields")]
		public string Addfields { get; set; }
	}

	[XmlRoot("PAGESIZE")]
	public class PAGESIZE
	{
		[XmlAttribute("height")]
		public string Height { get; set; }

		[XmlAttribute("width")]
		public string Width { get; set; }
	}

	[XmlRoot("TAGS")]
	public class TAGS
	{
		[XmlElement("TAG")]
		public List<string> TAG { get; set; }
	}
}

namespace Auto.Cirali.Objects.Textcluster
{
	[XmlRoot("ATOM")]
	public class ATOM
	{
		[XmlText]
		public string Text { get; set; }

		[XmlAttribute("bold")]
		public string Bold { get; set; }

		[XmlAttribute("fontblue")]
		public string Fontblue { get; set; }

		[XmlAttribute("fontface")]
		public string Fontface { get; set; }

		[XmlAttribute("fontgreen")]
		public string Fontgreen { get; set; }

		[XmlAttribute("fontred")]
		public string Fontred { get; set; }

		[XmlAttribute("fontsize")]
		public string Fontsize { get; set; }

		[XmlAttribute("italic")]
		public string Italic { get; set; }

		[XmlAttribute("underline")]
		public string Underline { get; set; }
	}
}

namespace Auto.Cirali.Objects.Dropdown
{
	[XmlRoot("ITEM")]
	public class ITEM
	{
		[XmlText]
		public string Text { get; set; }

		[XmlAttribute("map")]
		public string Map { get; set; }

		[XmlAttribute("validate1")]
		public string Validate1 { get; set; }

		[XmlAttribute("validate2")]
		public string Validate2 { get; set; }

		[XmlAttribute("validate3")]
		public string Validate3 { get; set; }

		[XmlAttribute("valparam1")]
		public string Valparam1 { get; set; }

		[XmlAttribute("valparam2")]
		public string Valparam2 { get; set; }

		[XmlAttribute("valparam3")]
		public string Valparam3 { get; set; }
	}
}

namespace Auto.Cirali.Objects
{
	[XmlRoot("BUTTON")]
	public class BUTTON
	{
		[XmlText]
		public string Text { get; set; }

		[XmlAttribute("blue")]
		public byte Blue { get; set; }

		[XmlAttribute("bold")]
		public string Bold { get; set; }

		[XmlAttribute("fontface")]
		public string Fontface { get; set; }

		[XmlAttribute("fontsize")]
		public byte Fontsize { get; set; }

		[XmlAttribute("green")]
		public byte Green { get; set; }

		[XmlAttribute("height")]
		public string Height { get; set; }

		[XmlAttribute("objid")]
		public string Objid { get; set; }

		[XmlAttribute("page")]
		public byte Page { get; set; }

		[XmlAttribute("print")]
		public string Print { get; set; }

		[XmlAttribute("red")]
		public byte Red { get; set; }

		[XmlAttribute("validate1")]
		public string Validate1 { get; set; }

		[XmlAttribute("width")]
		public string Width { get; set; }

		[XmlAttribute("x")]
		public string X { get; set; }

		[XmlAttribute("y")]
		public string Y { get; set; }
	}

	[XmlRoot("CHECKBOX")]
	public class CHECKBOX
	{
		[XmlText]
		public byte Text { get; set; }

		[XmlAttribute("active")]
		public string Active { get; set; }

		[XmlAttribute("blue")]
		public string Blue { get; set; }

		[XmlAttribute("fsdeletelabel")]
		public string Fsdeletelabel { get; set; }

		[XmlAttribute("fsend")]
		public string Fsend { get; set; }

		[XmlAttribute("fshidden")]
		public string Fshidden { get; set; }

		[XmlAttribute("fslast")]
		public string Fslast { get; set; }

		[XmlAttribute("fslegend")]
		public string Fslegend { get; set; }

		[XmlAttribute("fsnext")]
		public string Fsnext { get; set; }

		[XmlAttribute("fsnextlabel")]
		public string Fsnextlabel { get; set; }

		[XmlAttribute("fsstart")]
		public string Fsstart { get; set; }

		[XmlAttribute("group")]
		public string Group { get; set; }

		[XmlAttribute("group_exclusive")]
		public string Group_exclusive { get; set; }

		[XmlAttribute("height")]
		public string Height { get; set; }

		[XmlAttribute("hidden")]
		public string Hidden { get; set; }

		[XmlAttribute("htmldisabled")]
		public string Htmldisabled { get; set; }

		[XmlAttribute("label")]
		public string Label { get; set; }

		[XmlAttribute("mustfill")]
		public string Mustfill { get; set; }

		[XmlAttribute("name")]
		public string Name { get; set; }

		[XmlAttribute("nobarrier")]
		public string Nobarrier { get; set; }

		[XmlAttribute("objid")]
		public string Objid { get; set; }

		[XmlAttribute("objnext")]
		public string Objnext { get; set; }

		[XmlAttribute("objprev")]
		public string Objprev { get; set; }

		[XmlAttribute("page")]
		public byte Page { get; set; }

		[XmlAttribute("print")]
		public string Print { get; set; }

		[XmlAttribute("printborder")]
		public string Printborder { get; set; }

		[XmlAttribute("radio")]
		public string Radio { get; set; }

		[XmlAttribute("tab")]
		public string Tab { get; set; }

		[XmlAttribute("validate1")]
		public string Validate1 { get; set; }

		[XmlAttribute("validate2")]
		public string Validate2 { get; set; }

		[XmlAttribute("validate3")]
		public string Validate3 { get; set; }

		[XmlAttribute("validate4")]
		public string Validate4 { get; set; }

		[XmlAttribute("valparam1")]
		public string Valparam1 { get; set; }

		[XmlAttribute("valparam2")]
		public string Valparam2 { get; set; }

		[XmlAttribute("valparam3")]
		public string Valparam3 { get; set; }

		[XmlAttribute("valparam4")]
		public string Valparam4 { get; set; }

		[XmlAttribute("width")]
		public string Width { get; set; }

		[XmlAttribute("x")]
		public string X { get; set; }

		[XmlAttribute("y")]
		public string Y { get; set; }
	}

	[XmlRoot("CONTAINER")]
	public class CONTAINER
	{
		[XmlText]
		public string Text { get; set; }

		[XmlAttribute("height")]
		public string Height { get; set; }

		[XmlAttribute("name")]
		public string Name { get; set; }

		[XmlAttribute("objid")]
		public string Objid { get; set; }

		[XmlAttribute("objprev")]
		public string Objprev { get; set; }

		[XmlAttribute("page")]
		public byte Page { get; set; }

		[XmlAttribute("width")]
		public string Width { get; set; }

		[XmlAttribute("x")]
		public string X { get; set; }

		[XmlAttribute("y")]
		public string Y { get; set; }
	}

	[XmlRoot("DROPDOWN")]
	public class DROPDOWN
	{
		[XmlElement("ITEM")]
		public List<Dropdown.ITEM> Items { get; set; }

		[XmlElement("VALUE")]
		public string VALUE { get; set; }

		[XmlAttribute("active")]
		public string Active { get; set; }

		[XmlAttribute("blue")]
		public string Blue { get; set; }

		[XmlAttribute("bold")]
		public string Bold { get; set; }

		[XmlAttribute("custom_height")]
		public string Custom_height { get; set; }

		[XmlAttribute("editable")]
		public string Editable { get; set; }

		[XmlAttribute("fontface")]
		public string Fontface { get; set; }

		[XmlAttribute("fontred")]
		public string Fontred { get; set; }

		[XmlAttribute("fontsize")]
		public byte Fontsize { get; set; }

		[XmlAttribute("fsend")]
		public string Fsend { get; set; }

		[XmlAttribute("fsstart")]
		public string Fsstart { get; set; }

		[XmlAttribute("green")]
		public string Green { get; set; }

		[XmlAttribute("group")]
		public string Group { get; set; }

		[XmlAttribute("height")]
		public string Height { get; set; }

		[XmlAttribute("hidden")]
		public string Hidden { get; set; }

		[XmlAttribute("ignorefontheight")]
		public string Ignorefontheight { get; set; }

		[XmlAttribute("italic")]
		public string Italic { get; set; }

		[XmlAttribute("label")]
		public string Label { get; set; }

		[XmlAttribute("name")]
		public string Name { get; set; }

		[XmlAttribute("nobarrier")]
		public string Nobarrier { get; set; }

		[XmlAttribute("objid")]
		public string Objid { get; set; }

		[XmlAttribute("objnext")]
		public string Objnext { get; set; }

		[XmlAttribute("objprev")]
		public string Objprev { get; set; }

		[XmlAttribute("page")]
		public byte Page { get; set; }

		[XmlAttribute("print")]
		public string Print { get; set; }

		[XmlAttribute("red")]
		public string Red { get; set; }

		[XmlAttribute("underline")]
		public string Underline { get; set; }

		[XmlAttribute("validate1")]
		public string Validate1 { get; set; }

		[XmlAttribute("validate2")]
		public string Validate2 { get; set; }

		[XmlAttribute("valparam1")]
		public string Valparam1 { get; set; }

		[XmlAttribute("valparam2")]
		public string Valparam2 { get; set; }

		[XmlAttribute("width")]
		public string Width { get; set; }

		[XmlAttribute("x")]
		public string X { get; set; }

		[XmlAttribute("y")]
		public string Y { get; set; }
	}

	[XmlRoot("FRAME")]
	public class FRAME
	{
		[XmlAttribute("height")]
		public string Height { get; set; }

		[XmlAttribute("name")]
		public string Name { get; set; }

		[XmlAttribute("objid")]
		public string Objid { get; set; }

		[XmlAttribute("page")]
		public byte Page { get; set; }

		[XmlAttribute("width")]
		public string Width { get; set; }

		[XmlAttribute("x")]
		public string X { get; set; }

		[XmlAttribute("y")]
		public string Y { get; set; }
	}

	[XmlRoot("HOTSPOT")]
	public class HOTSPOT
	{
		[XmlAttribute("height")]
		public string Height { get; set; }

		[XmlAttribute("name")]
		public string Name { get; set; }

		[XmlAttribute("objid")]
		public string Objid { get; set; }

		[XmlAttribute("page")]
		public byte Page { get; set; }

		[XmlAttribute("print")]
		public string Print { get; set; }

		[XmlAttribute("tab")]
		public string Tab { get; set; }

		[XmlAttribute("validate1")]
		public string Validate1 { get; set; }

		[XmlAttribute("validate4")]
		public string Validate4 { get; set; }

		[XmlAttribute("valparam1")]
		public string Valparam1 { get; set; }

		[XmlAttribute("valparam4")]
		public string Valparam4 { get; set; }

		[XmlAttribute("width")]
		public string Width { get; set; }

		[XmlAttribute("x")]
		public string X { get; set; }

		[XmlAttribute("y")]
		public string Y { get; set; }
	}

	[XmlRoot("IMAGE")]
	public class IMAGE
	{
		[XmlText]
		public byte[] Text { get; set; }

		[XmlAttribute("decodedlength")]
		public ushort Decodedlength { get; set; }

		[XmlAttribute("grayscale")]
		public string Grayscale { get; set; }

		[XmlAttribute("halt")]
		public string Halt { get; set; }

		[XmlAttribute("height")]
		public string Height { get; set; }

		[XmlAttribute("mimetype")]
		public string Mimetype { get; set; }

		[XmlAttribute("name")]
		public string Name { get; set; }

		[XmlAttribute("objid")]
		public string Objid { get; set; }

		[XmlAttribute("objnext")]
		public string Objnext { get; set; }

		[XmlAttribute("objprev")]
		public string Objprev { get; set; }

		[XmlAttribute("page")]
		public byte Page { get; set; }

		[XmlAttribute("print")]
		public string Print { get; set; }

		[XmlAttribute("sizetype")]
		public string Sizetype { get; set; }

		[XmlAttribute("url")]
		public string Url { get; set; }

		[XmlAttribute("view")]
		public string View { get; set; }

		[XmlAttribute("width")]
		public string Width { get; set; }

		[XmlAttribute("x")]
		public string X { get; set; }

		[XmlAttribute("y")]
		public string Y { get; set; }
	}

	[XmlRoot("INFO")]
	public class INFO
	{
		[XmlText]
		public string Text { get; set; }

		[XmlAttribute("customizable")]
		public string Customizable { get; set; }

		[XmlAttribute("fsend")]
		public string Fsend { get; set; }

		[XmlAttribute("fsstart")]
		public string Fsstart { get; set; }

		[XmlAttribute("height")]
		public string Height { get; set; }

		[XmlAttribute("iconsize")]
		public string Iconsize { get; set; }

		[XmlAttribute("name")]
		public string Name { get; set; }

		[XmlAttribute("objid")]
		public string Objid { get; set; }

		[XmlAttribute("objnext")]
		public string Objnext { get; set; }

		[XmlAttribute("objprev")]
		public string Objprev { get; set; }

		[XmlAttribute("page")]
		public byte Page { get; set; }

		[XmlAttribute("tab")]
		public string Tab { get; set; }

		[XmlAttribute("width")]
		public string Width { get; set; }

		[XmlAttribute("x")]
		public string X { get; set; }

		[XmlAttribute("y")]
		public string Y { get; set; }
	}

	[XmlRoot("LINE")]
	public class LINE
	{
		[XmlAttribute("blue")]
		public string Blue { get; set; }

		[XmlAttribute("green")]
		public string Green { get; set; }

		[XmlAttribute("hidden")]
		public string Hidden { get; set; }

		[XmlAttribute("linesize")]
		public string Linesize { get; set; }

		[XmlAttribute("name")]
		public string Name { get; set; }

		[XmlAttribute("objid")]
		public string Objid { get; set; }

		[XmlAttribute("page")]
		public byte Page { get; set; }

		[XmlAttribute("print")]
		public string Print { get; set; }

		[XmlAttribute("red")]
		public string Red { get; set; }

		[XmlAttribute("view")]
		public string View { get; set; }

		[XmlAttribute("x")]
		public string X { get; set; }

		[XmlAttribute("x2")]
		public string X2 { get; set; }

		[XmlAttribute("y")]
		public string Y { get; set; }

		[XmlAttribute("y2")]
		public string Y2 { get; set; }
	}

	[XmlRoot("RECTANGLE")]
	public class RECTANGLE
	{
		[XmlAttribute("blue")]
		public byte Blue { get; set; }

		[XmlAttribute("drawtype")]
		public string Drawtype { get; set; }

		[XmlAttribute("green")]
		public byte Green { get; set; }

		[XmlAttribute("height")]
		public string Height { get; set; }

		[XmlAttribute("hidden")]
		public string Hidden { get; set; }

		[XmlAttribute("linesize")]
		public string Linesize { get; set; }

		[XmlAttribute("name")]
		public string Name { get; set; }

		[XmlAttribute("objid")]
		public string Objid { get; set; }

		[XmlAttribute("orientation")]
		public string Orientation { get; set; }

		[XmlAttribute("page")]
		public byte Page { get; set; }

		[XmlAttribute("print")]
		public string Print { get; set; }

		[XmlAttribute("red")]
		public byte Red { get; set; }

		[XmlAttribute("shape")]
		public string Shape { get; set; }

		[XmlAttribute("view")]
		public string View { get; set; }

		[XmlAttribute("width")]
		public string Width { get; set; }

		[XmlAttribute("x")]
		public string X { get; set; }

		[XmlAttribute("y")]
		public string Y { get; set; }
	}

	[XmlRoot("TEXT")]
	public class TEXT
	{
		[XmlText]
		public string Text { get; set; }

		[XmlAttribute("align")]
		public string Align { get; set; }

		[XmlAttribute("angle")]
		public byte Angle { get; set; }

		[XmlAttribute("bold")]
		public string Bold { get; set; }

		[XmlAttribute("fontblue")]
		public string Fontblue { get; set; }

		[XmlAttribute("fontface")]
		public string Fontface { get; set; }

		[XmlAttribute("fontgreen")]
		public string Fontgreen { get; set; }

		[XmlAttribute("fontred")]
		public string Fontred { get; set; }

		[XmlAttribute("fontsize")]
		public byte Fontsize { get; set; }

		[XmlAttribute("fsdeletelabel")]
		public string Fsdeletelabel { get; set; }

		[XmlAttribute("fsend")]
		public string Fsend { get; set; }

		[XmlAttribute("fshidden")]
		public string Fshidden { get; set; }

		[XmlAttribute("fslast")]
		public string Fslast { get; set; }

		[XmlAttribute("fslegend")]
		public string Fslegend { get; set; }

		[XmlAttribute("fsnext")]
		public string Fsnext { get; set; }

		[XmlAttribute("fsnextlabel")]
		public string Fsnextlabel { get; set; }

		[XmlAttribute("fsstart")]
		public string Fsstart { get; set; }

		[XmlAttribute("height")]
		public string Height { get; set; }

		[XmlAttribute("hidden")]
		public string Hidden { get; set; }

		[XmlAttribute("hstruct")]
		public string Hstruct { get; set; }

		[XmlAttribute("italic")]
		public string Italic { get; set; }

		[XmlAttribute("lineheight")]
		public string Lineheight { get; set; }

		[XmlAttribute("name")]
		public string Name { get; set; }

		[XmlAttribute("objid")]
		public string Objid { get; set; }

		[XmlAttribute("objnext")]
		public string Objnext { get; set; }

		[XmlAttribute("objprev")]
		public string Objprev { get; set; }

		[XmlAttribute("page")]
		public byte Page { get; set; }

		[XmlAttribute("print")]
		public string Print { get; set; }

		[XmlAttribute("ulend")]
		public string Ulend { get; set; }

		[XmlAttribute("ulstart")]
		public string Ulstart { get; set; }

		[XmlAttribute("underline")]
		public string Underline { get; set; }

		[XmlAttribute("validate1")]
		public string Validate1 { get; set; }

		[XmlAttribute("validate2")]
		public string Validate2 { get; set; }

		[XmlAttribute("valparam1")]
		public string Valparam1 { get; set; }

		[XmlAttribute("view")]
		public string View { get; set; }

		[XmlAttribute("width")]
		public string Width { get; set; }

		[XmlAttribute("x")]
		public string X { get; set; }

		[XmlAttribute("y")]
		public string Y { get; set; }
	}

	[XmlRoot("TEXTAREA")]
	public class TEXTAREA
	{
		[XmlText]
		public string Text { get; set; }

		[XmlAttribute("active")]
		public string Active { get; set; }

		[XmlAttribute("blue")]
		public string Blue { get; set; }

		[XmlAttribute("bold")]
		public string Bold { get; set; }

		[XmlAttribute("border")]
		public string Border { get; set; }

		[XmlAttribute("customizable")]
		public string Customizable { get; set; }

		[XmlAttribute("fontface")]
		public string Fontface { get; set; }

		[XmlAttribute("fontsize")]
		public byte Fontsize { get; set; }

		[XmlAttribute("fsbase")]
		public string Fsbase { get; set; }

		[XmlAttribute("fsdeletelabel")]
		public string Fsdeletelabel { get; set; }

		[XmlAttribute("fsend")]
		public string Fsend { get; set; }

		[XmlAttribute("fshidden")]
		public string Fshidden { get; set; }

		[XmlAttribute("fslast")]
		public string Fslast { get; set; }

		[XmlAttribute("fslegend")]
		public string Fslegend { get; set; }

		[XmlAttribute("fsmin")]
		public string Fsmin { get; set; }

		[XmlAttribute("fsnext")]
		public string Fsnext { get; set; }

		[XmlAttribute("fsnextlabel")]
		public string Fsnextlabel { get; set; }

		[XmlAttribute("fsstart")]
		public string Fsstart { get; set; }

		[XmlAttribute("group")]
		public ushort Group { get; set; }

		[XmlAttribute("height")]
		public string Height { get; set; }

		[XmlAttribute("hidden")]
		public string Hidden { get; set; }

		[XmlAttribute("htmlhidden")]
		public string Htmlhidden { get; set; }

		[XmlAttribute("ignorelines")]
		public string Ignorelines { get; set; }

		[XmlAttribute("label")]
		public string Label { get; set; }

		[XmlAttribute("lineheight")]
		public string Lineheight { get; set; }

		[XmlAttribute("lines")]
		public byte Lines { get; set; }

		[XmlAttribute("linesize")]
		public string Linesize { get; set; }

		[XmlAttribute("maxlen")]
		public ushort Maxlen { get; set; }

		[XmlAttribute("mustfill")]
		public string Mustfill { get; set; }

		[XmlAttribute("name")]
		public string Name { get; set; }

		[XmlAttribute("nobarrier")]
		public string Nobarrier { get; set; }

		[XmlAttribute("objid")]
		public string Objid { get; set; }

		[XmlAttribute("objnext")]
		public string Objnext { get; set; }

		[XmlAttribute("objprev")]
		public string Objprev { get; set; }

		[XmlAttribute("page")]
		public byte Page { get; set; }

		[XmlAttribute("print")]
		public string Print { get; set; }

		[XmlAttribute("tab")]
		public string Tab { get; set; }

		[XmlAttribute("validate1")]
		public string Validate1 { get; set; }

		[XmlAttribute("validate2")]
		public string Validate2 { get; set; }

		[XmlAttribute("valparam1")]
		public string Valparam1 { get; set; }

		[XmlAttribute("valparam2")]
		public string Valparam2 { get; set; }

		[XmlAttribute("view")]
		public string View { get; set; }

		[XmlAttribute("width")]
		public string Width { get; set; }

		[XmlAttribute("x")]
		public string X { get; set; }

		[XmlAttribute("y")]
		public string Y { get; set; }
	}

	[XmlRoot("TEXTCLUSTER")]
	public class TEXTCLUSTER
	{
		[XmlElement("ATOM")]
		public Textcluster.ATOM ATOM { get; set; }

		[XmlAttribute("align")]
		public string Align { get; set; }

		[XmlAttribute("angle")]
		public string Angle { get; set; }

		[XmlAttribute("fsend")]
		public string Fsend { get; set; }

		[XmlAttribute("fshidden")]
		public string Fshidden { get; set; }

		[XmlAttribute("fslegend")]
		public string Fslegend { get; set; }

		[XmlAttribute("fsstart")]
		public string Fsstart { get; set; }

		[XmlAttribute("height")]
		public string Height { get; set; }

		[XmlAttribute("hstruct")]
		public string Hstruct { get; set; }

		[XmlAttribute("lineheight")]
		public string Lineheight { get; set; }

		[XmlAttribute("name")]
		public string Name { get; set; }

		[XmlAttribute("objid")]
		public string Objid { get; set; }

		[XmlAttribute("objnext")]
		public string Objnext { get; set; }

		[XmlAttribute("objprev")]
		public string Objprev { get; set; }

		[XmlAttribute("page")]
		public byte Page { get; set; }

		[XmlAttribute("print")]
		public string Print { get; set; }

		[XmlAttribute("ulend")]
		public string Ulend { get; set; }

		[XmlAttribute("ulstart")]
		public string Ulstart { get; set; }

		[XmlAttribute("view")]
		public string View { get; set; }

		[XmlAttribute("width")]
		public string Width { get; set; }

		[XmlAttribute("x")]
		public string X { get; set; }

		[XmlAttribute("y")]
		public string Y { get; set; }
	}

	[XmlRoot("TEXTFIELD")]
	public class TEXTFIELD
	{
		[XmlText]
		public string Text { get; set; }

		[XmlAttribute("active")]
		public string Active { get; set; }

		[XmlAttribute("align")]
		public string Align { get; set; }

		[XmlAttribute("blue")]
		public string Blue { get; set; }

		[XmlAttribute("bold")]
		public string Bold { get; set; }

		[XmlAttribute("border")]
		public string Border { get; set; }

		[XmlAttribute("custom_height")]
		public string Custom_height { get; set; }

		[XmlAttribute("fontface")]
		public string Fontface { get; set; }

		[XmlAttribute("fontred")]
		public string Fontred { get; set; }

		[XmlAttribute("fontsize")]
		public string Fontsize { get; set; }

		[XmlAttribute("fsbase")]
		public string Fsbase { get; set; }

		[XmlAttribute("fsdeletelabel")]
		public string Fsdeletelabel { get; set; }

		[XmlAttribute("fsend")]
		public string Fsend { get; set; }

		[XmlAttribute("fshidden")]
		public string Fshidden { get; set; }

		[XmlAttribute("fslast")]
		public string Fslast { get; set; }

		[XmlAttribute("fslegend")]
		public string Fslegend { get; set; }

		[XmlAttribute("fsmin")]
		public string Fsmin { get; set; }

		[XmlAttribute("fsnext")]
		public string Fsnext { get; set; }

		[XmlAttribute("fsnextlabel")]
		public string Fsnextlabel { get; set; }

		[XmlAttribute("fsstart")]
		public string Fsstart { get; set; }

		[XmlAttribute("green")]
		public string Green { get; set; }

		[XmlAttribute("group")]
		public string Group { get; set; }

		[XmlAttribute("height")]
		public string Height { get; set; }

		[XmlAttribute("hidden")]
		public string Hidden { get; set; }

		[XmlAttribute("htmlhidden")]
		public string Htmlhidden { get; set; }

		[XmlAttribute("ignorefontheight")]
		public string Ignorefontheight { get; set; }

		[XmlAttribute("label")]
		public string Label { get; set; }

		[XmlAttribute("linesize")]
		public string Linesize { get; set; }

		[XmlAttribute("maxlen")]
		public byte Maxlen { get; set; }

		[XmlAttribute("mustfill")]
		public string Mustfill { get; set; }

		[XmlAttribute("name")]
		public string Name { get; set; }

		[XmlAttribute("nobarrier")]
		public string Nobarrier { get; set; }

		[XmlAttribute("objid")]
		public string Objid { get; set; }

		[XmlAttribute("objnext")]
		public string Objnext { get; set; }

		[XmlAttribute("objprev")]
		public string Objprev { get; set; }

		[XmlAttribute("page")]
		public byte Page { get; set; }

		[XmlAttribute("print")]
		public string Print { get; set; }

		[XmlAttribute("red")]
		public string Red { get; set; }

		[XmlAttribute("tab")]
		public string Tab { get; set; }

		[XmlAttribute("validate1")]
		public string Validate1 { get; set; }

		[XmlAttribute("validate2")]
		public string Validate2 { get; set; }

		[XmlAttribute("validate3")]
		public string Validate3 { get; set; }

		[XmlAttribute("validate4")]
		public string Validate4 { get; set; }

		[XmlAttribute("validate5")]
		public string Validate5 { get; set; }

		[XmlAttribute("valparam1")]
		public string Valparam1 { get; set; }

		[XmlAttribute("valparam2")]
		public string Valparam2 { get; set; }

		[XmlAttribute("valparam3")]
		public string Valparam3 { get; set; }

		[XmlAttribute("valparam4")]
		public string Valparam4 { get; set; }

		[XmlAttribute("valparam5")]
		public string Valparam5 { get; set; }

		[XmlAttribute("view")]
		public string View { get; set; }

		[XmlAttribute("width")]
		public string Width { get; set; }

		[XmlAttribute("x")]
		public string X { get; set; }

		[XmlAttribute("y")]
		public string Y { get; set; }
	}
}

namespace Auto.Cirali.Workflow
{
	[XmlRoot("ATTACHMENTS")]
	public class ATTACHMENTS
	{
		[XmlAttribute("filter")]
		public string Filter { get; set; }

		[XmlAttribute("maxsize")]
		public byte Maxsize { get; set; }

		[XmlAttribute("sigma")]
		public byte Sigma { get; set; }
	}

	[XmlRoot("TRANSPONDER")]
	public class TRANSPONDER
	{
		[XmlElement("ENCRYPTION")]
		public string ENCRYPTION { get; set; }

		[XmlElement("HOST")]
		public string HOST { get; set; }

		[XmlElement("PORT")]
		public ushort PORT { get; set; }

		[XmlElement("PROCESS")]
		public string PROCESS { get; set; }

		[XmlElement("PROTOCOL")]
		public string PROTOCOL { get; set; }

		[XmlElement("SERVICE")]
		public string SERVICE { get; set; }

		[XmlElement("OSCI")]
		public Transponder.OSCI OSCI { get; set; }
	}
}

namespace Auto.Cirali.Workflow.Transponder
{
	[XmlRoot("OSCI")]
	public class OSCI
	{
		[XmlElement("ATTACHMENTS")] 
		public string ATTACHMENTS { get; set; }

		[XmlElement("BACKEND_CER")] 
		public byte[] BACKEND_CER { get; set; }

		[XmlElement("DEBUG_LEVEL")] 
		public string DEBUG_LEVEL { get; set; }

		[XmlElement("INTERMED_CER")] 
		public byte[] INTERMED_CER { get; set; }

		[XmlElement("INTERMED_URL")] 
		public string INTERMED_URL { get; set; }

		[XmlElement("SIGNATURE_NUMBER")] 
		public byte SIGNATURE_NUMBER { get; set; }
	}
}
