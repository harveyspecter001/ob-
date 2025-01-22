using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Notification
{
	// Token: 0x02000354 RID: 852
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NotificationsEvent : IMessage<NotificationsEvent>, IMessage, IEquatable<NotificationsEvent>, IDeepCloneable<NotificationsEvent>, IBufferMessage
	{
		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060027FD RID: 10237 RVA: 0x001C4CB4 File Offset: 0x001C2EB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<NotificationsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x001C4CC4 File Offset: 0x001C2EC4
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

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060027FF RID: 10239 RVA: 0x001C4CD4 File Offset: 0x001C2ED4
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

		// Token: 0x06002800 RID: 10240 RVA: 0x001C4CE4 File Offset: 0x001C2EE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NotificationsEvent()
		{
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x001C4CF4 File Offset: 0x001C2EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NotificationsEvent(NotificationsEvent other)
		{
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x001C4D04 File Offset: 0x001C2F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NotificationsEvent Clone()
		{
			return null;
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06002803 RID: 10243 RVA: 0x001C4D14 File Offset: 0x001C2F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Flags
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x001C4D24 File Offset: 0x001C2F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x001C4D34 File Offset: 0x001C2F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(NotificationsEvent other)
		{
			return true;
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x001C4D44 File Offset: 0x001C2F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x001C4D54 File Offset: 0x001C2F54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x001C4D64 File Offset: 0x001C2F64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x001C4D74 File Offset: 0x001C2F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x001C4D84 File Offset: 0x001C2F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x001C4D94 File Offset: 0x001C2F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(NotificationsEvent other)
		{
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x001C4DA4 File Offset: 0x001C2FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x001C4DB4 File Offset: 0x001C2FB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x001C4DC4 File Offset: 0x001C2FC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static NotificationsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					NotificationsEvent._repeated_flags_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				case 5:
					NotificationsEvent._parser = new MessageParser<NotificationsEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 5;
			}
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x001C4EC4 File Offset: 0x001C30C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GSZy6GOhcu7ZhxWSy8Gq()
		{
			return true;
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x001C4ECC File Offset: 0x001C30CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NotificationsEvent UWUDiVOhUntrlITGfBIG()
		{
			return null;
		}

		// Token: 0x04000E3A RID: 3642
		private static readonly MessageParser<NotificationsEvent> _parser;

		// Token: 0x04000E3B RID: 3643
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E3C RID: 3644
		public const int FlagsFieldNumber = 1;

		// Token: 0x04000E3D RID: 3645
		private static readonly FieldCodec<int> _repeated_flags_codec;

		// Token: 0x04000E3E RID: 3646
		private readonly RepeatedField<int> flags_;

		// Token: 0x04000E3F RID: 3647
		internal static NotificationsEvent fOjIVMOhlTMXZu6ES7jm;
	}
}
