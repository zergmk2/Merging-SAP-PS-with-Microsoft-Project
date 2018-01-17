
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
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using SAP.Connector;

namespace CSAPData
{
  /// <summary>
  /// A typed collection of BAPI_NETWORK_ACTIVITY_UP elements.
  /// </summary>
  [Serializable]
  public class BAPI_NETWORK_ACTIVITY_UPTable : SAPTable 
  {
  
    /// <summary>
    /// Returns the element type BAPI_NETWORK_ACTIVITY_UP.
    /// </summary>
    /// <returns>The type BAPI_NETWORK_ACTIVITY_UP.</returns>
    public override Type GetElementType() 
    {
        return (typeof(BAPI_NETWORK_ACTIVITY_UP));
    }

    /// <summary>
    /// Creates an empty new row of type BAPI_NETWORK_ACTIVITY_UP.
    /// </summary>
    /// <returns>The newBAPI_NETWORK_ACTIVITY_UP.</returns>
    public override object CreateNewRow()
    { 
        return new BAPI_NETWORK_ACTIVITY_UP();
    }
     
    /// <summary>
    /// The indexer of the collection.
    /// </summary>
    public BAPI_NETWORK_ACTIVITY_UP this[int index] 
    {
        get 
        {
            return ((BAPI_NETWORK_ACTIVITY_UP)(List[index]));
        }
        set 
        {
            List[index] = value;
        }
    }
        
    /// <summary>
    /// Adds a BAPI_NETWORK_ACTIVITY_UP to the end of the collection.
    /// </summary>
    /// <param name="value">The BAPI_NETWORK_ACTIVITY_UP to be added to the end of the collection.</param>
    /// <returns>The index of the newBAPI_NETWORK_ACTIVITY_UP.</returns>
    public int Add(BAPI_NETWORK_ACTIVITY_UP value) 
    {
        return List.Add(value);
    }
        
    /// <summary>
    /// Inserts a BAPI_NETWORK_ACTIVITY_UP into the collection at the specified index.
    /// </summary>
    /// <param name="index">The zero-based index at which value should be inserted.</param>
    /// <param name="value">The BAPI_NETWORK_ACTIVITY_UP to insert.</param>
    public void Insert(int index, BAPI_NETWORK_ACTIVITY_UP value) 
    {
        List.Insert(index, value);
    }
        
    /// <summary>
    /// Searches for the specified BAPI_NETWORK_ACTIVITY_UP and returnes the zero-based index of the first occurrence in the collection.
    /// </summary>
    /// <param name="value">The BAPI_NETWORK_ACTIVITY_UP to locate in the collection.</param>
    /// <returns>The index of the object found or -1.</returns>
    public int IndexOf(BAPI_NETWORK_ACTIVITY_UP value) 
    {
        return List.IndexOf(value);
    }
        
    /// <summary>
    /// Determines wheter an element is in the collection.
    /// </summary>
    /// <param name="value">The BAPI_NETWORK_ACTIVITY_UP to locate in the collection.</param>
    /// <returns>True if found; else false.</returns>
    public bool Contains(BAPI_NETWORK_ACTIVITY_UP value) 
    {
        return List.Contains(value);
    }
        
    /// <summary>
    /// Removes the first occurrence of the specified BAPI_NETWORK_ACTIVITY_UP from the collection.
    /// </summary>
    /// <param name="value">The BAPI_NETWORK_ACTIVITY_UP to remove from the collection.</param>
    public void Remove(BAPI_NETWORK_ACTIVITY_UP value) 
    {
        List.Remove(value);
    }

    /// <summary>
    /// Copies the contents of the BAPI_NETWORK_ACTIVITY_UPTable to the specified one-dimensional array starting at the specified index in the target array.
    /// </summary>
    /// <param name="array">The one-dimensional destination array.</param>           
    /// <param name="index">The zero-based index in array at which copying begins.</param>           
    public void CopyTo(BAPI_NETWORK_ACTIVITY_UP[] array, int index) 
    {
        List.CopyTo(array, index);
	}
  }
}
