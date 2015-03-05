/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class Row : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Row(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Row obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Row() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_Row(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public RakNetListCellPointer cells {
    set {
      RakNetPINVOKE.Row_cells_set(swigCPtr, RakNetListCellPointer.getCPtr(value));
    } 
    get {
      IntPtr cPtr = RakNetPINVOKE.Row_cells_get(swigCPtr);
      RakNetListCellPointer ret = (cPtr == IntPtr.Zero) ? null : new RakNetListCellPointer(cPtr, false);
      return ret;
    } 
  }

  public void UpdateCell(uint columnIndex, double value) {
    RakNetPINVOKE.Row_UpdateCell__SWIG_0(swigCPtr, columnIndex, value);
  }

  public void UpdateCell(uint columnIndex, string str) {
    RakNetPINVOKE.Row_UpdateCell__SWIG_1(swigCPtr, columnIndex, str);
  }

  public void UpdateCell(uint columnIndex, int byteLength, byte[] inByteArray) {
    RakNetPINVOKE.Row_UpdateCell__SWIG_2(swigCPtr, columnIndex, byteLength, inByteArray);
  }

  public Row() : this(RakNetPINVOKE.new_Row(), true) {
  }

}

}
