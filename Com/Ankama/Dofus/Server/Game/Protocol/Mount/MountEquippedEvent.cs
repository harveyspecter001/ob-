using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x02000381 RID: 897
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountEquippedEvent : IMessage<MountEquippedEvent>, IMessage, IEquatable<MountEquippedEvent>, IDeepCloneable<MountEquippedEvent>, IBufferMessage
	{
		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06002A10 RID: 10768 RVA: 0x001C8850 File Offset: 0x001C6A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MountEquippedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x001C8860 File Offset: 0x001C6A60
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

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06002A12 RID: 10770 RVA: 0x001C8870 File Offset: 0x001C6A70
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

		// Token: 0x06002A13 RID: 10771 RVA: 0x001C8880 File Offset: 0x001C6A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountEquippedEvent()
		{
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x001C8890 File Offset: 0x001C6A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountEquippedEvent(MountEquippedEvent other)
		{
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x001C88A0 File Offset: 0x001C6AA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountEquippedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06002A16 RID: 10774 RVA: 0x001C88B0 File Offset: 0x001C6AB0
		// (set) Token: 0x06002A17 RID: 10775 RVA: 0x001C88C0 File Offset: 0x001C6AC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MountData MountData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x001C88D0 File Offset: 0x001C6AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x001C88E0 File Offset: 0x001C6AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountEquippedEvent other)
		{
			return true;
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x001C88F0 File Offset: 0x001C6AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x001C8900 File Offset: 0x001C6B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x001C8910 File Offset: 0x001C6B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x001C8920 File Offset: 0x001C6B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x001C8930 File Offset: 0x001C6B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x001C8940 File Offset: 0x001C6B40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountEquippedEvent other)
		{
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x001C8950 File Offset: 0x001C6B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x001C8960 File Offset: 0x001C6B60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x001C8970 File Offset: 0x001C6B70
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountEquippedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return;
				case 4:
					MountEquippedEvent._parser = new MessageParser<MountEquippedEvent>(() => null);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x001C8A54 File Offset: 0x001C6C54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jaiE6vOrUXpil0m2VDEP()
		{
			return true;
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x001C8A5C File Offset: 0x001C6C5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountEquippedEvent UTUHSsOrvfdCpnC7YNfQ()
		{
			return null;
		}

		// Token: 0x04000EDD RID: 3805
		private static readonly MessageParser<MountEquippedEvent> _parser;

		// Token: 0x04000EDE RID: 3806
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EDF RID: 3807
		public const int MountDataFieldNumber = 1;

		// Token: 0x04000EE0 RID: 3808
		private MountData mountData_;

		// Token: 0x04000EE1 RID: 3809
		private static MountEquippedEvent lao3fAOrcXjtjEqtnIf3;
	}
}
