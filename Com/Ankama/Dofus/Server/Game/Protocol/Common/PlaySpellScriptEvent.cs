using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000BB5 RID: 2997
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlaySpellScriptEvent : IMessage<PlaySpellScriptEvent>, IMessage, IEquatable<PlaySpellScriptEvent>, IDeepCloneable<PlaySpellScriptEvent>, IBufferMessage
	{
		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x06009034 RID: 36916 RVA: 0x0026D300 File Offset: 0x0026B500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlaySpellScriptEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x06009035 RID: 36917 RVA: 0x0026D310 File Offset: 0x0026B510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x06009036 RID: 36918 RVA: 0x0026D320 File Offset: 0x0026B520
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06009037 RID: 36919 RVA: 0x0026D330 File Offset: 0x0026B530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlaySpellScriptEvent()
		{
		}

		// Token: 0x06009038 RID: 36920 RVA: 0x0026D340 File Offset: 0x0026B540
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlaySpellScriptEvent(PlaySpellScriptEvent other)
		{
		}

		// Token: 0x06009039 RID: 36921 RVA: 0x0026D350 File Offset: 0x0026B550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlaySpellScriptEvent Clone()
		{
			return null;
		}

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x0600903A RID: 36922 RVA: 0x0026D360 File Offset: 0x0026B560
		// (set) Token: 0x0600903B RID: 36923 RVA: 0x0026D370 File Offset: 0x0026B570
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ScriptId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600903C RID: 36924 RVA: 0x0026D380 File Offset: 0x0026B580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600903D RID: 36925 RVA: 0x0026D390 File Offset: 0x0026B590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PlaySpellScriptEvent other)
		{
			return true;
		}

		// Token: 0x0600903E RID: 36926 RVA: 0x0026D3A0 File Offset: 0x0026B5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600903F RID: 36927 RVA: 0x0026D3B0 File Offset: 0x0026B5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009040 RID: 36928 RVA: 0x0026D3C0 File Offset: 0x0026B5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009041 RID: 36929 RVA: 0x0026D3D0 File Offset: 0x0026B5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009042 RID: 36930 RVA: 0x0026D3E0 File Offset: 0x0026B5E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009043 RID: 36931 RVA: 0x0026D3F0 File Offset: 0x0026B5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PlaySpellScriptEvent other)
		{
		}

		// Token: 0x06009044 RID: 36932 RVA: 0x0026D400 File Offset: 0x0026B600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009045 RID: 36933 RVA: 0x0026D410 File Offset: 0x0026B610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009046 RID: 36934 RVA: 0x0026D420 File Offset: 0x0026B620
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PlaySpellScriptEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					PlaySpellScriptEvent._parser = new MessageParser<PlaySpellScriptEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06009047 RID: 36935 RVA: 0x0026D518 File Offset: 0x0026B718
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OgTKEWJ2sZRAJrXgjyuM()
		{
			return true;
		}

		// Token: 0x06009048 RID: 36936 RVA: 0x0026D520 File Offset: 0x0026B720
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PlaySpellScriptEvent bprUlIJ2duf2cWE6wL0D()
		{
			return null;
		}

		// Token: 0x040035B8 RID: 13752
		private static readonly MessageParser<PlaySpellScriptEvent> _parser;

		// Token: 0x040035B9 RID: 13753
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035BA RID: 13754
		public const int ScriptIdFieldNumber = 1;

		// Token: 0x040035BB RID: 13755
		private int scriptId_;

		// Token: 0x040035BC RID: 13756
		internal static PlaySpellScriptEvent C67KybJ2guUXy4oSgilx;
	}
}
