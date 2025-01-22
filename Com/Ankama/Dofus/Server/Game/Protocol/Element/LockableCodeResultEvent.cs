using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Element
{
	// Token: 0x020007D4 RID: 2004
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LockableCodeResultEvent : IMessage<LockableCodeResultEvent>, IMessage, IEquatable<LockableCodeResultEvent>, IDeepCloneable<LockableCodeResultEvent>, IBufferMessage
	{
		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06006213 RID: 25107 RVA: 0x00222384 File Offset: 0x00220584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LockableCodeResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06006214 RID: 25108 RVA: 0x00222394 File Offset: 0x00220594
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x06006215 RID: 25109 RVA: 0x002223A4 File Offset: 0x002205A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006216 RID: 25110 RVA: 0x002223B4 File Offset: 0x002205B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LockableCodeResultEvent()
		{
		}

		// Token: 0x06006217 RID: 25111 RVA: 0x002223C4 File Offset: 0x002205C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LockableCodeResultEvent(LockableCodeResultEvent other)
		{
		}

		// Token: 0x06006218 RID: 25112 RVA: 0x002223D4 File Offset: 0x002205D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LockableCodeResultEvent Clone()
		{
			return null;
		}

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x06006219 RID: 25113 RVA: 0x002223E4 File Offset: 0x002205E4
		// (set) Token: 0x0600621A RID: 25114 RVA: 0x002223F8 File Offset: 0x002205F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LockableCodeResultEvent.Types.LockableResult Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (LockableCodeResultEvent.Types.LockableResult)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600621B RID: 25115 RVA: 0x00222408 File Offset: 0x00220608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600621C RID: 25116 RVA: 0x00222418 File Offset: 0x00220618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(LockableCodeResultEvent other)
		{
			return true;
		}

		// Token: 0x0600621D RID: 25117 RVA: 0x00222428 File Offset: 0x00220628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600621E RID: 25118 RVA: 0x00222438 File Offset: 0x00220638
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600621F RID: 25119 RVA: 0x00222448 File Offset: 0x00220648
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006220 RID: 25120 RVA: 0x00222458 File Offset: 0x00220658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006221 RID: 25121 RVA: 0x00222468 File Offset: 0x00220668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006222 RID: 25122 RVA: 0x00222478 File Offset: 0x00220678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(LockableCodeResultEvent other)
		{
		}

		// Token: 0x06006223 RID: 25123 RVA: 0x00222488 File Offset: 0x00220688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006224 RID: 25124 RVA: 0x00222498 File Offset: 0x00220698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006225 RID: 25125 RVA: 0x002224A8 File Offset: 0x002206A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static LockableCodeResultEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					LockableCodeResultEvent._parser = new MessageParser<LockableCodeResultEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06006226 RID: 25126 RVA: 0x00222574 File Offset: 0x00220774
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M56CcoOFvMRBOlyLTfXE()
		{
			return true;
		}

		// Token: 0x06006227 RID: 25127 RVA: 0x0022257C File Offset: 0x0022077C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LockableCodeResultEvent SPMV9hOFo2wop9Wx4LxW()
		{
			return null;
		}

		// Token: 0x0400227B RID: 8827
		private static readonly MessageParser<LockableCodeResultEvent> _parser;

		// Token: 0x0400227C RID: 8828
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400227D RID: 8829
		public const int ResultFieldNumber = 1;

		// Token: 0x0400227E RID: 8830
		private LockableCodeResultEvent.Types.LockableResult result_;

		// Token: 0x0400227F RID: 8831
		internal static LockableCodeResultEvent AGaojoOFU2QoakvFiDsj;

		// Token: 0x020007D5 RID: 2005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06006228 RID: 25128 RVA: 0x002D37A8 File Offset: 0x002D19A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020007D6 RID: 2006
			public enum LockableResult
			{
				// Token: 0x04002281 RID: 8833
				[OriginalName("UNLOCKED")]
				Unlocked,
				// Token: 0x04002282 RID: 8834
				[OriginalName("CODE_ERROR")]
				CodeError,
				// Token: 0x04002283 RID: 8835
				[OriginalName("UNLOCK_FORBIDDEN")]
				UnlockForbidden
			}
		}
	}
}
