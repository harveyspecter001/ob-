using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x020001F5 RID: 501
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpellPositions : IMessage<SpellPositions>, IMessage, IEquatable<SpellPositions>, IDeepCloneable<SpellPositions>, IBufferMessage
	{
		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x001AD840 File Offset: 0x001ABA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpellPositions> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x001AD850 File Offset: 0x001ABA50
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

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600177F RID: 6015 RVA: 0x001AD860 File Offset: 0x001ABA60
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

		// Token: 0x06001780 RID: 6016 RVA: 0x001AD870 File Offset: 0x001ABA70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellPositions()
		{
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x001AD880 File Offset: 0x001ABA80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellPositions(SpellPositions other)
		{
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x001AD890 File Offset: 0x001ABA90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellPositions Clone()
		{
			return null;
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x001AD8A0 File Offset: 0x001ABAA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> Positions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x001AD8B0 File Offset: 0x001ABAB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x001AD8C0 File Offset: 0x001ABAC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SpellPositions other)
		{
			return true;
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x001AD8D0 File Offset: 0x001ABAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x001AD8E0 File Offset: 0x001ABAE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x001AD8F0 File Offset: 0x001ABAF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x001AD900 File Offset: 0x001ABB00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x001AD910 File Offset: 0x001ABB10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x001AD920 File Offset: 0x001ABB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SpellPositions other)
		{
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x001AD930 File Offset: 0x001ABB30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x001AD940 File Offset: 0x001ABB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x001AD950 File Offset: 0x001ABB50
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SpellPositions()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					SpellPositions._parser = new MessageParser<SpellPositions>(() => null);
					num2 = 2;
					continue;
				case 2:
					SpellPositions._repeated_positions_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 5;
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				case 5:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x001ADA3C File Offset: 0x001ABC3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ntiJupO1ZsMPYE7HqEfp()
		{
			return true;
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x001ADA44 File Offset: 0x001ABC44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SpellPositions W1lhQZO1qZcNPe1aePmR()
		{
			return null;
		}

		// Token: 0x04000865 RID: 2149
		private static readonly MessageParser<SpellPositions> _parser;

		// Token: 0x04000866 RID: 2150
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000867 RID: 2151
		public const int PositionsFieldNumber = 1;

		// Token: 0x04000868 RID: 2152
		private static readonly FieldCodec<int> _repeated_positions_codec;

		// Token: 0x04000869 RID: 2153
		private readonly RepeatedField<int> positions_;

		// Token: 0x0400086A RID: 2154
		internal static SpellPositions SHnTu4O18pH7riacPnqj;
	}
}
