using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x02000695 RID: 1685
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightJoinRequest : IMessage<FightJoinRequest>, IMessage, IEquatable<FightJoinRequest>, IDeepCloneable<FightJoinRequest>, IBufferMessage
	{
		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06005220 RID: 21024 RVA: 0x002080D4 File Offset: 0x002062D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightJoinRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06005221 RID: 21025 RVA: 0x002080E4 File Offset: 0x002062E4
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

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06005222 RID: 21026 RVA: 0x002080F4 File Offset: 0x002062F4
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

		// Token: 0x06005223 RID: 21027 RVA: 0x00208104 File Offset: 0x00206304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightJoinRequest()
		{
		}

		// Token: 0x06005224 RID: 21028 RVA: 0x00208114 File Offset: 0x00206314
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightJoinRequest(FightJoinRequest other)
		{
		}

		// Token: 0x06005225 RID: 21029 RVA: 0x00208124 File Offset: 0x00206324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightJoinRequest Clone()
		{
			return null;
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06005226 RID: 21030 RVA: 0x00208134 File Offset: 0x00206334
		// (set) Token: 0x06005227 RID: 21031 RVA: 0x00208144 File Offset: 0x00206344
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long FighterId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06005228 RID: 21032 RVA: 0x00208154 File Offset: 0x00206354
		// (set) Token: 0x06005229 RID: 21033 RVA: 0x00208164 File Offset: 0x00206364
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FightId
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

		// Token: 0x0600522A RID: 21034 RVA: 0x00208174 File Offset: 0x00206374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600522B RID: 21035 RVA: 0x00208184 File Offset: 0x00206384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightJoinRequest other)
		{
			return true;
		}

		// Token: 0x0600522C RID: 21036 RVA: 0x00208194 File Offset: 0x00206394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600522D RID: 21037 RVA: 0x002081A4 File Offset: 0x002063A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600522E RID: 21038 RVA: 0x002081B4 File Offset: 0x002063B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600522F RID: 21039 RVA: 0x002081C4 File Offset: 0x002063C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005230 RID: 21040 RVA: 0x002081D4 File Offset: 0x002063D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005231 RID: 21041 RVA: 0x002081E4 File Offset: 0x002063E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightJoinRequest other)
		{
		}

		// Token: 0x06005232 RID: 21042 RVA: 0x002081F4 File Offset: 0x002063F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005233 RID: 21043 RVA: 0x00208204 File Offset: 0x00206404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005234 RID: 21044 RVA: 0x00208214 File Offset: 0x00206414
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightJoinRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					FightJoinRequest._parser = new MessageParser<FightJoinRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x0020830C File Offset: 0x0020650C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool opPl6HOPW8qmEFu0dkNh()
		{
			return true;
		}

		// Token: 0x06005236 RID: 21046 RVA: 0x00208314 File Offset: 0x00206514
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightJoinRequest ecmkWsOPhRGsjB7WpBSf()
		{
			return null;
		}

		// Token: 0x04001CF6 RID: 7414
		private static readonly MessageParser<FightJoinRequest> _parser;

		// Token: 0x04001CF7 RID: 7415
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CF8 RID: 7416
		public const int FighterIdFieldNumber = 1;

		// Token: 0x04001CF9 RID: 7417
		private long fighterId_;

		// Token: 0x04001CFA RID: 7418
		public const int FightIdFieldNumber = 2;

		// Token: 0x04001CFB RID: 7419
		private int fightId_;

		// Token: 0x04001CFC RID: 7420
		private static FightJoinRequest sy7W8OOPLv4aZtok5bac;
	}
}
