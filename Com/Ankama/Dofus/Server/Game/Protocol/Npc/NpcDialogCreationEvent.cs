using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc
{
	// Token: 0x02000337 RID: 823
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NpcDialogCreationEvent : IMessage<NpcDialogCreationEvent>, IMessage, IEquatable<NpcDialogCreationEvent>, IDeepCloneable<NpcDialogCreationEvent>, IBufferMessage
	{
		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x0600269E RID: 9886 RVA: 0x001C3198 File Offset: 0x001C1398
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<NpcDialogCreationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600269F RID: 9887 RVA: 0x001C31A8 File Offset: 0x001C13A8
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

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060026A0 RID: 9888 RVA: 0x001C31B8 File Offset: 0x001C13B8
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

		// Token: 0x060026A1 RID: 9889 RVA: 0x001C31C8 File Offset: 0x001C13C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NpcDialogCreationEvent()
		{
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x001C31D8 File Offset: 0x001C13D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NpcDialogCreationEvent(NpcDialogCreationEvent other)
		{
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x001C31E8 File Offset: 0x001C13E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NpcDialogCreationEvent Clone()
		{
			return null;
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x060026A4 RID: 9892 RVA: 0x001C31F8 File Offset: 0x001C13F8
		// (set) Token: 0x060026A5 RID: 9893 RVA: 0x001C3208 File Offset: 0x001C1408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MapId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x060026A6 RID: 9894 RVA: 0x001C3218 File Offset: 0x001C1418
		// (set) Token: 0x060026A7 RID: 9895 RVA: 0x001C3228 File Offset: 0x001C1428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NpcId
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

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x060026A8 RID: 9896 RVA: 0x001C3238 File Offset: 0x001C1438
		// (set) Token: 0x060026A9 RID: 9897 RVA: 0x001C324C File Offset: 0x001C144C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcDialogCreationEvent.Types.PortalType PortalType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (NpcDialogCreationEvent.Types.PortalType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x060026AA RID: 9898 RVA: 0x001C325C File Offset: 0x001C145C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPortalType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x001C326C File Offset: 0x001C146C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearPortalType()
		{
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x001C327C File Offset: 0x001C147C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x001C328C File Offset: 0x001C148C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(NpcDialogCreationEvent other)
		{
			return true;
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x001C329C File Offset: 0x001C149C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x001C32AC File Offset: 0x001C14AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x001C32BC File Offset: 0x001C14BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x001C32CC File Offset: 0x001C14CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x001C32DC File Offset: 0x001C14DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x001C32EC File Offset: 0x001C14EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(NpcDialogCreationEvent other)
		{
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x001C32FC File Offset: 0x001C14FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x001C330C File Offset: 0x001C150C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x001C331C File Offset: 0x001C151C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static NpcDialogCreationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					NpcDialogCreationEvent._parser = new MessageParser<NpcDialogCreationEvent>(() => null);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
					{
						num2 = 5;
					}
					break;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 != 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					return;
				case 5:
					NpcDialogCreationEvent.PortalTypeDefaultValue = NpcDialogCreationEvent.Types.PortalType.Unsupported;
					num2 = 4;
					break;
				}
			}
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x001C3428 File Offset: 0x001C1628
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jvxo3bOWMT3HSnB3MyV2()
		{
			return true;
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x001C3430 File Offset: 0x001C1630
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NpcDialogCreationEvent ph3aJtOWuXt5mJgU7bcu()
		{
			return null;
		}

		// Token: 0x04000DB6 RID: 3510
		private static readonly MessageParser<NpcDialogCreationEvent> _parser;

		// Token: 0x04000DB7 RID: 3511
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000DB8 RID: 3512
		private int _hasBits0;

		// Token: 0x04000DB9 RID: 3513
		public const int MapIdFieldNumber = 1;

		// Token: 0x04000DBA RID: 3514
		private long mapId_;

		// Token: 0x04000DBB RID: 3515
		public const int NpcIdFieldNumber = 2;

		// Token: 0x04000DBC RID: 3516
		private int npcId_;

		// Token: 0x04000DBD RID: 3517
		public const int PortalTypeFieldNumber = 3;

		// Token: 0x04000DBE RID: 3518
		private static readonly NpcDialogCreationEvent.Types.PortalType PortalTypeDefaultValue;

		// Token: 0x04000DBF RID: 3519
		private NpcDialogCreationEvent.Types.PortalType portalType_;

		// Token: 0x04000DC0 RID: 3520
		internal static NpcDialogCreationEvent JZnQLYOWS8SpGC2ekFEN;

		// Token: 0x02000338 RID: 824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060026B9 RID: 9913 RVA: 0x002B7ADC File Offset: 0x002B5CDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000339 RID: 825
			public enum PortalType
			{
				// Token: 0x04000DC2 RID: 3522
				[OriginalName("UNSUPPORTED")]
				Unsupported,
				// Token: 0x04000DC3 RID: 3523
				[OriginalName("ENUTROSOR")]
				Enutrosor,
				// Token: 0x04000DC4 RID: 3524
				[OriginalName("SRAMBAD")]
				Srambad,
				// Token: 0x04000DC5 RID: 3525
				[OriginalName("XELORIUM")]
				Xelorium,
				// Token: 0x04000DC6 RID: 3526
				[OriginalName("ECAFLIPUS")]
				Ecaflipus
			}
		}
	}
}
