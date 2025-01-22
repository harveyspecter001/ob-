using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C2C RID: 3116
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ArenaSwitchXpRewardsModeRequest : IMessage<ArenaSwitchXpRewardsModeRequest>, IMessage, IEquatable<ArenaSwitchXpRewardsModeRequest>, IDeepCloneable<ArenaSwitchXpRewardsModeRequest>, IBufferMessage
	{
		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x060095C5 RID: 38341 RVA: 0x002778B0 File Offset: 0x00275AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ArenaSwitchXpRewardsModeRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x060095C6 RID: 38342 RVA: 0x002778C0 File Offset: 0x00275AC0
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

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x060095C7 RID: 38343 RVA: 0x002778D0 File Offset: 0x00275AD0
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

		// Token: 0x060095C8 RID: 38344 RVA: 0x002778E0 File Offset: 0x00275AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaSwitchXpRewardsModeRequest()
		{
		}

		// Token: 0x060095C9 RID: 38345 RVA: 0x002778F0 File Offset: 0x00275AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaSwitchXpRewardsModeRequest(ArenaSwitchXpRewardsModeRequest other)
		{
		}

		// Token: 0x060095CA RID: 38346 RVA: 0x00277900 File Offset: 0x00275B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaSwitchXpRewardsModeRequest Clone()
		{
			return null;
		}

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x060095CB RID: 38347 RVA: 0x00277910 File Offset: 0x00275B10
		// (set) Token: 0x060095CC RID: 38348 RVA: 0x00277920 File Offset: 0x00275B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool XpRewards
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060095CD RID: 38349 RVA: 0x00277930 File Offset: 0x00275B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060095CE RID: 38350 RVA: 0x00277940 File Offset: 0x00275B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ArenaSwitchXpRewardsModeRequest other)
		{
			return true;
		}

		// Token: 0x060095CF RID: 38351 RVA: 0x00277950 File Offset: 0x00275B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060095D0 RID: 38352 RVA: 0x00277960 File Offset: 0x00275B60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060095D1 RID: 38353 RVA: 0x00277970 File Offset: 0x00275B70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060095D2 RID: 38354 RVA: 0x00277980 File Offset: 0x00275B80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060095D3 RID: 38355 RVA: 0x00277990 File Offset: 0x00275B90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060095D4 RID: 38356 RVA: 0x002779A0 File Offset: 0x00275BA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ArenaSwitchXpRewardsModeRequest other)
		{
		}

		// Token: 0x060095D5 RID: 38357 RVA: 0x002779B0 File Offset: 0x00275BB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060095D6 RID: 38358 RVA: 0x002779C0 File Offset: 0x00275BC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060095D7 RID: 38359 RVA: 0x002779D0 File Offset: 0x00275BD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ArenaSwitchXpRewardsModeRequest()
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
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				ArenaSwitchXpRewardsModeRequest._parser = new MessageParser<ArenaSwitchXpRewardsModeRequest>(() => null);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060095D8 RID: 38360 RVA: 0x00277AC8 File Offset: 0x00275CC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CuOKqcJXTg8BoZimcfrG()
		{
			return true;
		}

		// Token: 0x060095D9 RID: 38361 RVA: 0x00277AD0 File Offset: 0x00275CD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ArenaSwitchXpRewardsModeRequest XQBilWJXpfuDIa8JGFcO()
		{
			return null;
		}

		// Token: 0x040037C6 RID: 14278
		private static readonly MessageParser<ArenaSwitchXpRewardsModeRequest> _parser;

		// Token: 0x040037C7 RID: 14279
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037C8 RID: 14280
		public const int XpRewardsFieldNumber = 1;

		// Token: 0x040037C9 RID: 14281
		private bool xpRewards_;

		// Token: 0x040037CA RID: 14282
		internal static ArenaSwitchXpRewardsModeRequest YHPbIRJX7FYXpdbho2qZ;
	}
}
