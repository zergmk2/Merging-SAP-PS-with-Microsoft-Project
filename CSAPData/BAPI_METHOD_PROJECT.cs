
//------------------------------------------------------------------------------
// 
//     This code was generated by a SAP. NET Connector Proxy Generator Version 2.0
//     Created at 8/29/2009
//     Created from Windows
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// 
//------------------------------------------------------------------------------
using System;
using System.Text;
using System.Collections;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using SAP.Connector;

namespace CSAPData
{

  /// <summary>
  /// BAPI structure: Processing methods
  /// </summary>
  [RfcStructure(AbapName ="BAPI_METHOD_PROJECT" , Length = 160, Length2 = 320)]
  [Serializable]
  public class BAPI_METHOD_PROJECT : SAPStructure
  {
   

    /// <summary>
    /// Reference number for link object method - attribute
    /// </summary>
 
    [RfcField(AbapName = "REFNUMBER", RfcType = RFCTYPE.RFCTYPE_NUM, Length = 6, Length2 = 12, Offset = 0, Offset2 = 0)]
    [XmlElement("REFNUMBER", Form=XmlSchemaForm.Unqualified)]
    public string Refnumber
    { 
       get
       {
          return _Refnumber;
       }
       set
       {
          _Refnumber = value;
       }
    }
    private string _Refnumber;


    /// <summary>
    /// Object type
    /// </summary>
 
    [RfcField(AbapName = "OBJECTTYPE", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 32, Length2 = 64, Offset = 6, Offset2 = 12)]
    [XmlElement("OBJECTTYPE", Form=XmlSchemaForm.Unqualified)]
    public string Objecttype
    { 
       get
       {
          return _Objecttype;
       }
       set
       {
          _Objecttype = value;
       }
    }
    private string _Objecttype;


    /// <summary>
    /// Method
    /// </summary>
 
    [RfcField(AbapName = "METHOD", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 32, Length2 = 64, Offset = 38, Offset2 = 76)]
    [XmlElement("METHOD", Form=XmlSchemaForm.Unqualified)]
    public string Method
    { 
       get
       {
          return _Method;
       }
       set
       {
          _Method = value;
       }
    }
    private string _Method;


    /// <summary>
    /// SAP external object key
    /// </summary>
 
    [RfcField(AbapName = "OBJECTKEY", RfcType = RFCTYPE.RFCTYPE_CHAR, Length = 90, Length2 = 180, Offset = 70, Offset2 = 140)]
    [XmlElement("OBJECTKEY", Form=XmlSchemaForm.Unqualified)]
    public string Objectkey
    { 
       get
       {
          return _Objectkey;
       }
       set
       {
          _Objectkey = value;
       }
    }
    private string _Objectkey;

  }

}
