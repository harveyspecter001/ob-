using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Finish.Move
{
	// Token: 0x02000633 RID: 1587
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishMovesRequest : IMessage<FinishMovesRequest>, IMessage, IEquatable<FinishMovesRequest>, IDeepCloneable<FinishMovesRequest>, IBufferMessage
	{
		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06004CF7 RID: 19703 RVA: 0x001FF810 File Offset: 0x001FDA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishMovesRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06004CF8 RID: 19704 RVA: 0x001FF820 File Offset: 0x001FDA20
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

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06004CF9 RID: 19705 RVA: 0x001FF830 File Offset: 0x001FDA30
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

		// Token: 0x06004CFA RID: 19706 RVA: 0x001FF840 File Offset: 0x001FDA40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FinishMovesRequest()
		{
		}

		// Token: 0x06004CFB RID: 19707 RVA: 0x001FF850 File Offset: 0x001FDA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FinishMovesRequest(FinishMovesRequest other)
		{
		}

		// Token: 0x06004CFC RID: 19708 RVA: 0x001FF860 File Offset: 0x001FDA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FinishMovesRequest Clone()
		{
			return null;
		}

		// Token: 0x06004CFD RID: 19709 RVA: 0x001FF870 File Offset: 0x001FDA70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004CFE RID: 19710 RVA: 0x001FF880 File Offset: 0x001FDA80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FinishMovesRequest other)
		{
			return true;
		}

		// Token: 0x06004CFF RID: 19711 RVA: 0x001FF890 File Offset: 0x001FDA90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004D00 RID: 19712 RVA: 0x001FF8A0 File Offset: 0x001FDAA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004D01 RID: 19713 RVA: 0x001FF8B0 File Offset: 0x001FDAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004D02 RID: 19714 RVA: 0x001FF8C0 File Offset: 0x001FDAC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004D03 RID: 19715 RVA: 0x001FF8D0 File Offset: 0x001FDAD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x001FF8E0 File Offset: 0x001FDAE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FinishMovesRequest other)
		{
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x001FF8F0 File Offset: 0x001FDAF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x001FF900 File Offset: 0x001FDB00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x001FF910 File Offset: 0x001FDB10
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FinishMovesRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_49;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						continue;
					}
					FinishMovesRequest._parser = new MessageParser<FinishMovesRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 1;
					}
				}
				IL_49:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 2;
			}
		}

		// Token: 0x06004D08 RID: 19720 RVA: 0x001FF9E0 File Offset: 0x001FDBE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool irwIYWOieyu2rCMdtCn5()
		{
			return true;
		}

		// Token: 0x06004D09 RID: 19721 RVA: 0x001FF9E8 File Offset: 0x001FDBE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FinishMovesRequest orHgKbOi3dy9FHpGbe4d()
		{
			return null;
		}

		// Token: 0x04001AE2 RID: 6882
		private static readonly MessageParser<FinishMovesRequest> _parser;

		// Token: 0x04001AE3 RID: 6883
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001AE4 RID: 6884
		internal static FinishMovesRequest CPVxL8OiB1SFb6hm9pjK;
	}
}
