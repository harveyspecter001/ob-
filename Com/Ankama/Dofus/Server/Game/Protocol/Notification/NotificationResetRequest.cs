using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Notification
{
	// Token: 0x02000352 RID: 850
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NotificationResetRequest : IMessage<NotificationResetRequest>, IMessage, IEquatable<NotificationResetRequest>, IDeepCloneable<NotificationResetRequest>, IBufferMessage
	{
		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060027E5 RID: 10213 RVA: 0x001C4AD8 File Offset: 0x001C2CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NotificationResetRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060027E6 RID: 10214 RVA: 0x001C4AE8 File Offset: 0x001C2CE8
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

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060027E7 RID: 10215 RVA: 0x001C4AF8 File Offset: 0x001C2CF8
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

		// Token: 0x060027E8 RID: 10216 RVA: 0x001C4B08 File Offset: 0x001C2D08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NotificationResetRequest()
		{
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x001C4B18 File Offset: 0x001C2D18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NotificationResetRequest(NotificationResetRequest other)
		{
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x001C4B28 File Offset: 0x001C2D28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NotificationResetRequest Clone()
		{
			return null;
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x001C4B38 File Offset: 0x001C2D38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x001C4B48 File Offset: 0x001C2D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(NotificationResetRequest other)
		{
			return true;
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x001C4B58 File Offset: 0x001C2D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x001C4B68 File Offset: 0x001C2D68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x001C4B78 File Offset: 0x001C2D78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x001C4B88 File Offset: 0x001C2D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x001C4B98 File Offset: 0x001C2D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x001C4BA8 File Offset: 0x001C2DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(NotificationResetRequest other)
		{
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x001C4BB8 File Offset: 0x001C2DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x001C4BC8 File Offset: 0x001C2DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x001C4BD8 File Offset: 0x001C2DD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static NotificationResetRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					NotificationResetRequest._parser = new MessageParser<NotificationResetRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x001C4CA4 File Offset: 0x001C2EA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wd2tl4OhIyideviejeV6()
		{
			return true;
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x001C4CAC File Offset: 0x001C2EAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NotificationResetRequest ioU89QOhkrbZeNL8eaWT()
		{
			return null;
		}

		// Token: 0x04000E35 RID: 3637
		private static readonly MessageParser<NotificationResetRequest> _parser;

		// Token: 0x04000E36 RID: 3638
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E37 RID: 3639
		private static NotificationResetRequest qpAxKGOhKyC59vBX6cDA;
	}
}
