﻿#region User/License
// oio * 7/31/2012 * 11:12 PM

// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Drawing;
using gen.snd.Forms;
using gen.snd.Midi;
using gen.snd.Vst;
using gen.snd.Vst.Module;
using gen.snd.Vst.Xml;

namespace gen.snd
{
	public interface IMidiParserUI : INaudioVstWin
	{
		/// <summary></summary>
		IMidiParser MidiParser { get; }
		/// <summary></summary>
		void Action_MidiFileOpen();
		/// <summary></summary>
		void Action_MidiFileOpen(string filename, int trackNo);
		/// <summary></summary>
		void TrySetProgram(MidiSmfFile newfile, VstPlugin plugin);
		
		/// <summary></summary>
		event EventHandler ClearMidiTrack;
		/// <summary></summary>
		event EventHandler GotMidiFile;
	}

	
}
