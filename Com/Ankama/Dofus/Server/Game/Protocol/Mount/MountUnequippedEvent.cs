using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x02000383 RID: 899
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountUnequippedEvent : IMessage<MountUnequippedEvent>, IMessage, IEquatable<MountUnequippedEvent>, IDeepCloneable<MountUnequippedEvent>, IBufferMessage
	{
		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06002A2A RID: 10794 RVA: 0x001C8A64 File Offset: 0x001C6C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MountUnequippedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06002A2B RID: 10795 RVA: 0x001C8A74 File Offset: 0x001C6C74
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

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06002A2C RID: 10796 RVA: 0x001C8A84 File Offset: 0x001C6C84
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

		// Token: 0x06002A2D RID: 10797 RVA: 0x001C8A94 File Offset: 0x001C6C94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountUnequippedEvent()
		{
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x001C8AA4 File Offset: 0x001C6CA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountUnequippedEvent(MountUnequippedEvent other)
		{
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x001C8AB4 File Offset: 0x001C6CB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountUnequippedEvent Clone()
		{
			return null;
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x001C8AC4 File Offset: 0x001C6CC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x001C8AD4 File Offset: 0x001C6CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountUnequippedEvent other)
		{
			return true;
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x001C8AE4 File Offset: 0x001C6CE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x001C8AF4 File Offset: 0x001C6CF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x001C8B04 File Offset: 0x001C6D04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x001C8B14 File Offset: 0x001C6D14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x001C8B24 File Offset: 0x001C6D24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x001C8B34 File Offset: 0x001C6D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountUnequippedEvent other)
		{
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x001C8B44 File Offset: 0x001C6D44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x001C8B54 File Offset: 0x001C6D54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x001C8B64 File Offset: 0x001C6D64
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountUnequippedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					MountUnequippedEvent._parser = new MessageParser<MountUnequippedEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x001C8C48 File Offset: 0x001C6E48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cuDOaPOr1AMEqMs2f1Ry()
		{
			return true;
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x001C8C50 File Offset: 0x001C6E50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountUnequippedEvent iyYnAKOraRNclXGd2gfD()
		{
			return null;
		}

		// Token: 0x04000EE4 RID: 3812
		private static readonly MessageParser<MountUnequippedEvent> _parser;

		// Token: 0x04000EE5 RID: 3813
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EE6 RID: 3814
		private static MountUnequippedEvent N2b46YOronVIDRpu56AJ;
	}
}
