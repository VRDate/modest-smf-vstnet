﻿/*
 * Date: 11/12/2005
 * Time: 4:19 PM
 */

// Horse barn for rent

using System;
using CliEvent = System.EventArgs;

namespace gen.snd.Midi
{
	public interface IMidiParser_Parser
	{
		
		// =============================
		// TIME
		// =============================

		/// <summary>Measure:Bar:Ticks</summary>
		/// <param name="value">Pulses</param>
		/// <returns>Measure:Bar:Quarters:Ticks +/- Quarters</returns>
		string GetMbtString(ulong value);
		
		// =============================
		// META
		// =============================
		
		/// <summary>Gets a string value.</summary>
		/// <param name="offset"></param>
		/// <returns>UTF8 Decoded</returns>
		string GetMetaString(int offset);
    
    /// <summary>
    /// Return a string value per meta-event or throw exception.
    /// </summary>
    /// <param name="offset"></param>
    /// <returns></returns>		
		string GetMetaSTR(int offset);
		
		/// <summary>
		/// Place the imaginary caret one byte before the next read.
		/// </summary>
		/// <param name="offset"></param>
		/// <returns></returns>
		int GetMetaNextPos(int offset);
		
		/// <summary>
		/// There is no plus (its not used).
		/// Reason being, I've not ever encountered a RSE Meta event.
		/// </summary>
		/// <param name="offset"></param>
		/// <param name="plus"></param>
		/// <returns></returns>
		int GetMetaLen(int offset, int plus);
		
		/// <summary>Documentation needed</summary>
		/// <param name="offset"></param>
		/// <returns></returns>
		byte[] GetMetaValue(int offset);
		
		/// <summary>Documentation needed</summary>
		/// <param name="offset"></param>
		/// <returns></returns>
		byte[] GetMetaData(int offset);
		
		/// <summary>Documentation needed</summary>
		/// <param name="offset"></param>
		/// <returns></returns>
		byte[] GetMetaBString(int offset);
		
//		byte[] GetMetaStringValue(int offset);
//		byte[] GetMetaValue(int offset);
		
		// =================================
		// CH (string)
		// =================================
		
		/// <summary>
		/// Parse runningstatus channel bit (for messages that support this); Non-RSE
		/// </summary>
		/// <param name="v">message value bit</param>
		string chV(int v);
		
		/// <summary>
		/// process running status bit with event valuestring?; RSE specific
		/// </summary>
		/// <param name="v">message value bit</param>
		/// <returns>
		/// string.Format("{0} {1}", string.Format("{0:X2}", RunningStatus32), GetEventValueString(v))
		/// </returns>
		string chRseV(int v);
		
		/// <summary>
		/// Valid on one track after or during parse operation;
		/// Parse runningstatus channel bit.
		/// </summary>
		/// <remarks>
		/// For messages that support this.
		/// </remarks>
		string ch { get; }
		
		// =================================
		// NEXT.POS
		// =================================
		
    /// <summary>Next Position (rse)</summary>
		int GetNextRsePosition(int offset);
		
    /// <summary>Next Position (rse)</summary>
		int GetNextPosition(int offset);
		
		// =================================
		// VALUE.LEN
		// =================================
		
		/// <summary>Documentation needed</summary>
		int GetRseEventLength(int offset);
		
		/// <summary>Documentation needed</summary>
		int GetEventLength(int offset);
		
		// /// <summary>Documentation needed</summary>
		// int GetEventLength(int offset, int plus);
		
		// =================================
		// VALUE.EVENT
		// =================================
		
		/// <summary>Documentation needed</summary>
		byte[] GetRseEventValue(int offset);
		
		/// <summary>Documentation needed</summary>
		byte[] GetEventValue(int offset);
		
		// =================================
		// VALUE.EVENT-STRING
		// =================================
		
		/// <summary>Documentation needed</summary>
		string GetRseEventString(int offset);
		
		/// <summary>Documentation needed</summary>
		string GetEventString(int offset);
		
		// =================================
		// VALUE-STRING
		// =================================
		
    /// <summary> RSE </summary>
		string GetRseEventValueString(int offset);
		
		/// <summary>Documentation needed</summary>
		string GetEventValueString(int offset);
		
		// /// <summary>Documentation needed</summary>
		// string GetEventValueString(int offset, int plus);
	}
}
