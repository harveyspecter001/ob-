using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x0200086C RID: 2156
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BlockListEvent : IMessage<BlockListEvent>, IMessage, IEquatable<BlockListEvent>, IDeepCloneable<BlockListEvent>, IBufferMessage
	{
		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x060068B8 RID: 26808 RVA: 0x0022E1A4 File Offset: 0x0022C3A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BlockListEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x060068B9 RID: 26809 RVA: 0x0022E1B4 File Offset: 0x0022C3B4
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

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x060068BA RID: 26810 RVA: 0x0022E1C4 File Offset: 0x0022C3C4
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

		// Token: 0x060068BB RID: 26811 RVA: 0x0022E1D4 File Offset: 0x0022C3D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BlockListEvent()
		{
		}

		// Token: 0x060068BC RID: 26812 RVA: 0x0022E1E4 File Offset: 0x0022C3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BlockListEvent(BlockListEvent other)
		{
		}

		// Token: 0x060068BD RID: 26813 RVA: 0x0022E1F4 File Offset: 0x0022C3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BlockListEvent Clone()
		{
			return null;
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x060068BE RID: 26814 RVA: 0x0022E204 File Offset: 0x0022C404
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ContactInformation> Blocked
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x0022E214 File Offset: 0x0022C414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060068C0 RID: 26816 RVA: 0x0022E224 File Offset: 0x0022C424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BlockListEvent other)
		{
			return true;
		}

		// Token: 0x060068C1 RID: 26817 RVA: 0x0022E234 File Offset: 0x0022C434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060068C2 RID: 26818 RVA: 0x0022E244 File Offset: 0x0022C444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060068C3 RID: 26819 RVA: 0x0022E254 File Offset: 0x0022C454
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060068C4 RID: 26820 RVA: 0x0022E264 File Offset: 0x0022C464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060068C5 RID: 26821 RVA: 0x0022E274 File Offset: 0x0022C474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060068C6 RID: 26822 RVA: 0x0022E284 File Offset: 0x0022C484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BlockListEvent other)
		{
		}

		// Token: 0x060068C7 RID: 26823 RVA: 0x0022E294 File Offset: 0x0022C494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060068C8 RID: 26824 RVA: 0x0022E2A4 File Offset: 0x0022C4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060068C9 RID: 26825 RVA: 0x0022E2B4 File Offset: 0x0022C4B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BlockListEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						BlockListEvent._repeated_blocked_codec = FieldCodec.ForMessage<ContactInformation>(10U, SoahxDATSfKOdBga0Rlg.XVInXhlssT(SoahxDATSfKOdBga0Rlg.RnAATMkCyLh));
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						BlockListEvent._parser = new MessageParser<BlockListEvent>(() => null);
						num2 = 3;
						continue;
					case 5:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					break;
				}
				IL_63:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 5;
				continue;
				goto IL_63;
			}
		}

		// Token: 0x060068CA RID: 26826 RVA: 0x0022E3C0 File Offset: 0x0022C5C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sKE3WgJnhiNbhjaOjRFK()
		{
			return true;
		}

		// Token: 0x060068CB RID: 26827 RVA: 0x0022E3C8 File Offset: 0x0022C5C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BlockListEvent ykM8RcJnrTscHyO1iTDc()
		{
			return null;
		}

		// Token: 0x0400249D RID: 9373
		private static readonly MessageParser<BlockListEvent> _parser;

		// Token: 0x0400249E RID: 9374
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400249F RID: 9375
		public const int BlockedFieldNumber = 1;

		// Token: 0x040024A0 RID: 9376
		private static readonly FieldCodec<ContactInformation> _repeated_blocked_codec;

		// Token: 0x040024A1 RID: 9377
		private readonly RepeatedField<ContactInformation> blocked_;

		// Token: 0x040024A2 RID: 9378
		private static BlockListEvent S7lTREJnWdfIdhZe6Qkh;
	}
}
