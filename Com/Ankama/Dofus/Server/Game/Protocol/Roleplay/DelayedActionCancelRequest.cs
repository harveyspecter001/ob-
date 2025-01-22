using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay
{
	// Token: 0x02000180 RID: 384
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DelayedActionCancelRequest : IMessage<DelayedActionCancelRequest>, IMessage, IEquatable<DelayedActionCancelRequest>, IDeepCloneable<DelayedActionCancelRequest>, IBufferMessage
	{
		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x001A1110 File Offset: 0x0019F310
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<DelayedActionCancelRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x001A1120 File Offset: 0x0019F320
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

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x001A1130 File Offset: 0x0019F330
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

		// Token: 0x06001195 RID: 4501 RVA: 0x001A1140 File Offset: 0x0019F340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DelayedActionCancelRequest()
		{
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x001A1150 File Offset: 0x0019F350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DelayedActionCancelRequest(DelayedActionCancelRequest other)
		{
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x001A1160 File Offset: 0x0019F360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DelayedActionCancelRequest Clone()
		{
			return null;
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x001A1170 File Offset: 0x0019F370
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x001A1180 File Offset: 0x0019F380
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(DelayedActionCancelRequest other)
		{
			return true;
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x001A1190 File Offset: 0x0019F390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x001A11A0 File Offset: 0x0019F3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x001A11B0 File Offset: 0x0019F3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x001A11C0 File Offset: 0x0019F3C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x001A11D0 File Offset: 0x0019F3D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x001A11E0 File Offset: 0x0019F3E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(DelayedActionCancelRequest other)
		{
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x001A11F0 File Offset: 0x0019F3F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x001A1200 File Offset: 0x0019F400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x001A1210 File Offset: 0x0019F410
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DelayedActionCancelRequest()
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
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					DelayedActionCancelRequest._parser = new MessageParser<DelayedActionCancelRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x001A12F4 File Offset: 0x0019F4F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wcdte4OvLDmxjePhZ0jK()
		{
			return true;
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x001A12FC File Offset: 0x0019F4FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DelayedActionCancelRequest YSPdnZOvWDwBKVg4dYya()
		{
			return null;
		}

		// Token: 0x0400065C RID: 1628
		private static readonly MessageParser<DelayedActionCancelRequest> _parser;

		// Token: 0x0400065D RID: 1629
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400065E RID: 1630
		private static DelayedActionCancelRequest zsLriTOv6Kshv4VbB2SM;
	}
}
