using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x0200029E RID: 670
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyNameSetRequest : IMessage<PartyNameSetRequest>, IMessage, IEquatable<PartyNameSetRequest>, IDeepCloneable<PartyNameSetRequest>, IBufferMessage
	{
		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001F54 RID: 8020 RVA: 0x001B89BC File Offset: 0x001B6BBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PartyNameSetRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x001B89CC File Offset: 0x001B6BCC
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

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001F56 RID: 8022 RVA: 0x001B89DC File Offset: 0x001B6BDC
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

		// Token: 0x06001F57 RID: 8023 RVA: 0x001B89EC File Offset: 0x001B6BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyNameSetRequest()
		{
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x001B89FC File Offset: 0x001B6BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyNameSetRequest(PartyNameSetRequest other)
		{
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x001B8A0C File Offset: 0x001B6C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyNameSetRequest Clone()
		{
			return null;
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001F5A RID: 8026 RVA: 0x001B8A1C File Offset: 0x001B6C1C
		// (set) Token: 0x06001F5B RID: 8027 RVA: 0x001B8A2C File Offset: 0x001B6C2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PartyId
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

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001F5C RID: 8028 RVA: 0x001B8A3C File Offset: 0x001B6C3C
		// (set) Token: 0x06001F5D RID: 8029 RVA: 0x001B8A4C File Offset: 0x001B6C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
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

		// Token: 0x06001F5E RID: 8030 RVA: 0x001B8A5C File Offset: 0x001B6C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x001B8A6C File Offset: 0x001B6C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyNameSetRequest other)
		{
			return true;
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x001B8A7C File Offset: 0x001B6C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x001B8A8C File Offset: 0x001B6C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x001B8A9C File Offset: 0x001B6C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x001B8AAC File Offset: 0x001B6CAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x001B8ABC File Offset: 0x001B6CBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x001B8ACC File Offset: 0x001B6CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyNameSetRequest other)
		{
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x001B8ADC File Offset: 0x001B6CDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x001B8AEC File Offset: 0x001B6CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x001B8AFC File Offset: 0x001B6CFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyNameSetRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				case 2:
					PartyNameSetRequest._parser = new MessageParser<PartyNameSetRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x001B8BC8 File Offset: 0x001B6DC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cridkHOyHoevkYjaQdkA()
		{
			return true;
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x001B8BD0 File Offset: 0x001B6DD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyNameSetRequest YHBa65OyYd9qcDBILST2()
		{
			return null;
		}

		// Token: 0x04000B0E RID: 2830
		private static readonly MessageParser<PartyNameSetRequest> _parser;

		// Token: 0x04000B0F RID: 2831
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B10 RID: 2832
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000B11 RID: 2833
		private int partyId_;

		// Token: 0x04000B12 RID: 2834
		public const int NameFieldNumber = 2;

		// Token: 0x04000B13 RID: 2835
		private string name_;

		// Token: 0x04000B14 RID: 2836
		internal static PartyNameSetRequest vXLOEoOypcowprkiIMql;
	}
}
