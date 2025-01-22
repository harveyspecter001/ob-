using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay
{
	// Token: 0x0200017E RID: 382
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExitRequest : IMessage<ExitRequest>, IMessage, IEquatable<ExitRequest>, IDeepCloneable<ExitRequest>, IBufferMessage
	{
		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x001A0F1C File Offset: 0x0019F11C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExitRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x001A0F2C File Offset: 0x0019F12C
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

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x001A0F3C File Offset: 0x0019F13C
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

		// Token: 0x0600117D RID: 4477 RVA: 0x001A0F4C File Offset: 0x0019F14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExitRequest()
		{
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x001A0F5C File Offset: 0x0019F15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExitRequest(ExitRequest other)
		{
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x001A0F6C File Offset: 0x0019F16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExitRequest Clone()
		{
			return null;
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x001A0F7C File Offset: 0x0019F17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x001A0F8C File Offset: 0x0019F18C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExitRequest other)
		{
			return true;
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x001A0F9C File Offset: 0x0019F19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x001A0FAC File Offset: 0x0019F1AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x001A0FBC File Offset: 0x0019F1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x001A0FCC File Offset: 0x0019F1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x001A0FDC File Offset: 0x0019F1DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x001A0FEC File Offset: 0x0019F1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExitRequest other)
		{
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x001A0FFC File Offset: 0x0019F1FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x001A100C File Offset: 0x0019F20C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x001A101C File Offset: 0x0019F21C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExitRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					break;
				case 1:
					return;
				case 2:
					ExitRequest._parser = new MessageParser<ExitRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x001A1100 File Offset: 0x0019F300
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gvvvkBOv5wAjqEBULRO0()
		{
			return true;
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x001A1108 File Offset: 0x0019F308
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExitRequest Gyo9JPOvyQO855Y5Sqkd()
		{
			return null;
		}

		// Token: 0x04000657 RID: 1623
		private static readonly MessageParser<ExitRequest> _parser;

		// Token: 0x04000658 RID: 1624
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000659 RID: 1625
		internal static ExitRequest MKs2tmOvaJNV75y9cOjX;
	}
}
