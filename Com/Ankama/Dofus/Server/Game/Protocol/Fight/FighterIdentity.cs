using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x0200064A RID: 1610
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FighterIdentity : IMessage<FighterIdentity>, IMessage, IEquatable<FighterIdentity>, IDeepCloneable<FighterIdentity>, IBufferMessage
	{
		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06004E16 RID: 19990 RVA: 0x00203BFC File Offset: 0x00201DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FighterIdentity> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06004E17 RID: 19991 RVA: 0x00203C0C File Offset: 0x00201E0C
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

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06004E18 RID: 19992 RVA: 0x00203C1C File Offset: 0x00201E1C
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

		// Token: 0x06004E19 RID: 19993 RVA: 0x00203C2C File Offset: 0x00201E2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FighterIdentity()
		{
		}

		// Token: 0x06004E1A RID: 19994 RVA: 0x00203C3C File Offset: 0x00201E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FighterIdentity(FighterIdentity other)
		{
		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x00203C4C File Offset: 0x00201E4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FighterIdentity Clone()
		{
			return null;
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06004E1C RID: 19996 RVA: 0x00203C5C File Offset: 0x00201E5C
		// (set) Token: 0x06004E1D RID: 19997 RVA: 0x00203C6C File Offset: 0x00201E6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Id
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

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06004E1E RID: 19998 RVA: 0x00203C7C File Offset: 0x00201E7C
		// (set) Token: 0x06004E1F RID: 19999 RVA: 0x00203C90 File Offset: 0x00201E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Team Team
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Team)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06004E20 RID: 20000 RVA: 0x00203CA0 File Offset: 0x00201EA0
		// (set) Token: 0x06004E21 RID: 20001 RVA: 0x00203CB0 File Offset: 0x00201EB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FighterIdentity.Types.Player Player
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

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06004E22 RID: 20002 RVA: 0x00203CC0 File Offset: 0x00201EC0
		// (set) Token: 0x06004E23 RID: 20003 RVA: 0x00203CD0 File Offset: 0x00201ED0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FighterIdentity.Types.Monster Monster
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

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06004E24 RID: 20004 RVA: 0x00203CE0 File Offset: 0x00201EE0
		// (set) Token: 0x06004E25 RID: 20005 RVA: 0x00203CF0 File Offset: 0x00201EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FighterIdentity.Types.Companion Companion
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

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06004E26 RID: 20006 RVA: 0x00203D00 File Offset: 0x00201F00
		// (set) Token: 0x06004E27 RID: 20007 RVA: 0x00203D10 File Offset: 0x00201F10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FighterIdentity.Types.Summon Summon
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

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06004E28 RID: 20008 RVA: 0x00203D20 File Offset: 0x00201F20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FighterIdentity.IdentityOneofCase IdentityCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FighterIdentity.IdentityOneofCase)null;
			}
		}

		// Token: 0x06004E29 RID: 20009 RVA: 0x00203D34 File Offset: 0x00201F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearIdentity()
		{
		}

		// Token: 0x06004E2A RID: 20010 RVA: 0x00203D44 File Offset: 0x00201F44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004E2B RID: 20011 RVA: 0x00203D54 File Offset: 0x00201F54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FighterIdentity other)
		{
			return true;
		}

		// Token: 0x06004E2C RID: 20012 RVA: 0x00203D64 File Offset: 0x00201F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004E2D RID: 20013 RVA: 0x00203D74 File Offset: 0x00201F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004E2E RID: 20014 RVA: 0x00203D84 File Offset: 0x00201F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x00203D94 File Offset: 0x00201F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004E30 RID: 20016 RVA: 0x00203DA4 File Offset: 0x00201FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004E31 RID: 20017 RVA: 0x00203DB4 File Offset: 0x00201FB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FighterIdentity other)
		{
		}

		// Token: 0x06004E32 RID: 20018 RVA: 0x00203DC4 File Offset: 0x00201FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004E33 RID: 20019 RVA: 0x00203DD4 File Offset: 0x00201FD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004E34 RID: 20020 RVA: 0x00203DE4 File Offset: 0x00201FE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FighterIdentity()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					FighterIdentity._parser = new MessageParser<FighterIdentity>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
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
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x00203EB0 File Offset: 0x002020B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UT8vOTOi52lg5yWDBkbs()
		{
			return true;
		}

		// Token: 0x06004E36 RID: 20022 RVA: 0x00203EB8 File Offset: 0x002020B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FighterIdentity K37hmaOiyIVfSIoI7h6f()
		{
			return null;
		}

		// Token: 0x04001B4D RID: 6989
		private static readonly MessageParser<FighterIdentity> _parser;

		// Token: 0x04001B4E RID: 6990
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B4F RID: 6991
		public const int IdFieldNumber = 1;

		// Token: 0x04001B50 RID: 6992
		private long id_;

		// Token: 0x04001B51 RID: 6993
		public const int TeamFieldNumber = 2;

		// Token: 0x04001B52 RID: 6994
		private Team team_;

		// Token: 0x04001B53 RID: 6995
		public const int PlayerFieldNumber = 3;

		// Token: 0x04001B54 RID: 6996
		public const int MonsterFieldNumber = 4;

		// Token: 0x04001B55 RID: 6997
		public const int CompanionFieldNumber = 5;

		// Token: 0x04001B56 RID: 6998
		public const int SummonFieldNumber = 6;

		// Token: 0x04001B57 RID: 6999
		private object identity_;

		// Token: 0x04001B58 RID: 7000
		private FighterIdentity.IdentityOneofCase identityCase_;

		// Token: 0x04001B59 RID: 7001
		internal static FighterIdentity YIrtoBOiapHKcJKc1lTI;

		// Token: 0x0200064B RID: 1611
		public enum IdentityOneofCase
		{
			// Token: 0x04001B5B RID: 7003
			None,
			// Token: 0x04001B5C RID: 7004
			Player = 3,
			// Token: 0x04001B5D RID: 7005
			Monster,
			// Token: 0x04001B5E RID: 7006
			Companion,
			// Token: 0x04001B5F RID: 7007
			Summon
		}

		// Token: 0x0200064C RID: 1612
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06004E37 RID: 20023 RVA: 0x002C9B78 File Offset: 0x002C7D78
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200064D RID: 1613
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Player : IMessage<FighterIdentity.Types.Player>, IMessage, IEquatable<FighterIdentity.Types.Player>, IDeepCloneable<FighterIdentity.Types.Player>, IBufferMessage
			{
				// Token: 0x17000E24 RID: 3620
				// (get) Token: 0x06004E38 RID: 20024 RVA: 0x00302224 File Offset: 0x00300424
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<FighterIdentity.Types.Player> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000E25 RID: 3621
				// (get) Token: 0x06004E39 RID: 20025 RVA: 0x00302234 File Offset: 0x00300434
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

				// Token: 0x17000E26 RID: 3622
				// (get) Token: 0x06004E3A RID: 20026 RVA: 0x00302244 File Offset: 0x00300444
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

				// Token: 0x06004E3B RID: 20027 RVA: 0x00302254 File Offset: 0x00300454
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Player()
				{
				}

				// Token: 0x06004E3C RID: 20028 RVA: 0x00302264 File Offset: 0x00300464
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Player(FighterIdentity.Types.Player other)
				{
				}

				// Token: 0x06004E3D RID: 20029 RVA: 0x00302274 File Offset: 0x00300474
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FighterIdentity.Types.Player Clone()
				{
					return null;
				}

				// Token: 0x06004E3E RID: 20030 RVA: 0x00302284 File Offset: 0x00300484
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004E3F RID: 20031 RVA: 0x00302294 File Offset: 0x00300494
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(FighterIdentity.Types.Player other)
				{
					return true;
				}

				// Token: 0x06004E40 RID: 20032 RVA: 0x003022A4 File Offset: 0x003004A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004E41 RID: 20033 RVA: 0x003022B4 File Offset: 0x003004B4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004E42 RID: 20034 RVA: 0x003022C4 File Offset: 0x003004C4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004E43 RID: 20035 RVA: 0x003022D4 File Offset: 0x003004D4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004E44 RID: 20036 RVA: 0x003022E4 File Offset: 0x003004E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004E45 RID: 20037 RVA: 0x003022F4 File Offset: 0x003004F4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(FighterIdentity.Types.Player other)
				{
				}

				// Token: 0x06004E46 RID: 20038 RVA: 0x00302304 File Offset: 0x00300504
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004E47 RID: 20039 RVA: 0x00302314 File Offset: 0x00300514
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004E48 RID: 20040 RVA: 0x00302324 File Offset: 0x00300524
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Player()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 2;
					for (;;)
					{
						int num2 = num;
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_C1;
							case 2:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 3:
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 4;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 != 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 4:
								FighterIdentity.Types.Player._parser = new MessageParser<FighterIdentity.Types.Player>(() => null);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							}
							return;
						}
						IL_C1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num = 3;
					}
				}

				// Token: 0x06004E49 RID: 20041 RVA: 0x0030240C File Offset: 0x0030060C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool suCEliGPBFr4eUYD2i3s()
				{
					return true;
				}

				// Token: 0x06004E4A RID: 20042 RVA: 0x00302414 File Offset: 0x00300614
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static FighterIdentity.Types.Player U9QeqlGPeAY0FVOBHCnv()
				{
					return null;
				}

				// Token: 0x04001B60 RID: 7008
				private static readonly MessageParser<FighterIdentity.Types.Player> _parser;

				// Token: 0x04001B61 RID: 7009
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001B62 RID: 7010
				internal static FighterIdentity.Types.Player dYQcl0GPADxHUo5u4Be6;
			}

			// Token: 0x0200064F RID: 1615
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Monster : IMessage<FighterIdentity.Types.Monster>, IMessage, IEquatable<FighterIdentity.Types.Monster>, IDeepCloneable<FighterIdentity.Types.Monster>, IBufferMessage
			{
				// Token: 0x17000E27 RID: 3623
				// (get) Token: 0x06004E50 RID: 20048 RVA: 0x0030241C File Offset: 0x0030061C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<FighterIdentity.Types.Monster> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000E28 RID: 3624
				// (get) Token: 0x06004E51 RID: 20049 RVA: 0x0030242C File Offset: 0x0030062C
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

				// Token: 0x17000E29 RID: 3625
				// (get) Token: 0x06004E52 RID: 20050 RVA: 0x0030243C File Offset: 0x0030063C
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

				// Token: 0x06004E53 RID: 20051 RVA: 0x0030244C File Offset: 0x0030064C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Monster()
				{
				}

				// Token: 0x06004E54 RID: 20052 RVA: 0x0030245C File Offset: 0x0030065C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Monster(FighterIdentity.Types.Monster other)
				{
				}

				// Token: 0x06004E55 RID: 20053 RVA: 0x0030246C File Offset: 0x0030066C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FighterIdentity.Types.Monster Clone()
				{
					return null;
				}

				// Token: 0x17000E2A RID: 3626
				// (get) Token: 0x06004E56 RID: 20054 RVA: 0x0030247C File Offset: 0x0030067C
				// (set) Token: 0x06004E57 RID: 20055 RVA: 0x0030248C File Offset: 0x0030068C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int MonsterId
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

				// Token: 0x06004E58 RID: 20056 RVA: 0x0030249C File Offset: 0x0030069C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004E59 RID: 20057 RVA: 0x003024AC File Offset: 0x003006AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(FighterIdentity.Types.Monster other)
				{
					return true;
				}

				// Token: 0x06004E5A RID: 20058 RVA: 0x003024BC File Offset: 0x003006BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004E5B RID: 20059 RVA: 0x003024CC File Offset: 0x003006CC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004E5C RID: 20060 RVA: 0x003024DC File Offset: 0x003006DC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004E5D RID: 20061 RVA: 0x003024EC File Offset: 0x003006EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004E5E RID: 20062 RVA: 0x003024FC File Offset: 0x003006FC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004E5F RID: 20063 RVA: 0x0030250C File Offset: 0x0030070C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(FighterIdentity.Types.Monster other)
				{
				}

				// Token: 0x06004E60 RID: 20064 RVA: 0x0030251C File Offset: 0x0030071C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004E61 RID: 20065 RVA: 0x0030252C File Offset: 0x0030072C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004E62 RID: 20066 RVA: 0x0030253C File Offset: 0x0030073C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Monster()
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
							FighterIdentity.Types.Monster._parser = new MessageParser<FighterIdentity.Types.Monster>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
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

				// Token: 0x06004E63 RID: 20067 RVA: 0x00302608 File Offset: 0x00300808
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool CfipehGPRHLbHK3xbyaP()
				{
					return true;
				}

				// Token: 0x06004E64 RID: 20068 RVA: 0x00302610 File Offset: 0x00300810
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static FighterIdentity.Types.Monster AaW5v9GPOy079qv7XxKX()
				{
					return null;
				}

				// Token: 0x04001B65 RID: 7013
				private static readonly MessageParser<FighterIdentity.Types.Monster> _parser;

				// Token: 0x04001B66 RID: 7014
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001B67 RID: 7015
				public const int MonsterIdFieldNumber = 1;

				// Token: 0x04001B68 RID: 7016
				private int monsterId_;

				// Token: 0x04001B69 RID: 7017
				private static FighterIdentity.Types.Monster SRrJpeGP38SAbgyMBLYi;
			}

			// Token: 0x02000651 RID: 1617
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Companion : IMessage<FighterIdentity.Types.Companion>, IMessage, IEquatable<FighterIdentity.Types.Companion>, IDeepCloneable<FighterIdentity.Types.Companion>, IBufferMessage
			{
				// Token: 0x17000E2B RID: 3627
				// (get) Token: 0x06004E6A RID: 20074 RVA: 0x00302618 File Offset: 0x00300818
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<FighterIdentity.Types.Companion> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000E2C RID: 3628
				// (get) Token: 0x06004E6B RID: 20075 RVA: 0x00302628 File Offset: 0x00300828
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

				// Token: 0x17000E2D RID: 3629
				// (get) Token: 0x06004E6C RID: 20076 RVA: 0x00302638 File Offset: 0x00300838
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

				// Token: 0x06004E6D RID: 20077 RVA: 0x00302648 File Offset: 0x00300848
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Companion()
				{
				}

				// Token: 0x06004E6E RID: 20078 RVA: 0x00302658 File Offset: 0x00300858
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Companion(FighterIdentity.Types.Companion other)
				{
				}

				// Token: 0x06004E6F RID: 20079 RVA: 0x00302668 File Offset: 0x00300868
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FighterIdentity.Types.Companion Clone()
				{
					return null;
				}

				// Token: 0x17000E2E RID: 3630
				// (get) Token: 0x06004E70 RID: 20080 RVA: 0x00302678 File Offset: 0x00300878
				// (set) Token: 0x06004E71 RID: 20081 RVA: 0x00302688 File Offset: 0x00300888
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int CompanionId
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

				// Token: 0x17000E2F RID: 3631
				// (get) Token: 0x06004E72 RID: 20082 RVA: 0x00302698 File Offset: 0x00300898
				// (set) Token: 0x06004E73 RID: 20083 RVA: 0x003026A8 File Offset: 0x003008A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public FighterIdentity Master
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

				// Token: 0x06004E74 RID: 20084 RVA: 0x003026B8 File Offset: 0x003008B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004E75 RID: 20085 RVA: 0x003026C8 File Offset: 0x003008C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(FighterIdentity.Types.Companion other)
				{
					return true;
				}

				// Token: 0x06004E76 RID: 20086 RVA: 0x003026D8 File Offset: 0x003008D8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004E77 RID: 20087 RVA: 0x003026E8 File Offset: 0x003008E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004E78 RID: 20088 RVA: 0x003026F8 File Offset: 0x003008F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004E79 RID: 20089 RVA: 0x00302708 File Offset: 0x00300908
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004E7A RID: 20090 RVA: 0x00302718 File Offset: 0x00300918
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004E7B RID: 20091 RVA: 0x00302728 File Offset: 0x00300928
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(FighterIdentity.Types.Companion other)
				{
				}

				// Token: 0x06004E7C RID: 20092 RVA: 0x00302738 File Offset: 0x00300938
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004E7D RID: 20093 RVA: 0x00302748 File Offset: 0x00300948
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004E7E RID: 20094 RVA: 0x00302758 File Offset: 0x00300958
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Companion()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 2;
					for (;;)
					{
						int num2 = num;
						for (;;)
						{
							switch (num2)
							{
							default:
								goto IL_35;
							case 1:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 3;
								break;
							case 2:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
								{
									num2 = 0;
								}
								break;
							case 3:
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
								{
									num2 = 0;
								}
								break;
							case 4:
								return;
							}
						}
						IL_35:
						FighterIdentity.Types.Companion._parser = new MessageParser<FighterIdentity.Types.Companion>(() => null);
						num = 4;
					}
				}

				// Token: 0x06004E7F RID: 20095 RVA: 0x00302828 File Offset: 0x00300A28
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool kO1b0uGPGCeRKmVtJ4ZW()
				{
					return true;
				}

				// Token: 0x06004E80 RID: 20096 RVA: 0x00302830 File Offset: 0x00300A30
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static FighterIdentity.Types.Companion KfOLCRGPge3VMymsaIvQ()
				{
					return null;
				}

				// Token: 0x04001B6C RID: 7020
				private static readonly MessageParser<FighterIdentity.Types.Companion> _parser;

				// Token: 0x04001B6D RID: 7021
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001B6E RID: 7022
				public const int CompanionIdFieldNumber = 1;

				// Token: 0x04001B6F RID: 7023
				private int companionId_;

				// Token: 0x04001B70 RID: 7024
				public const int MasterFieldNumber = 2;

				// Token: 0x04001B71 RID: 7025
				private FighterIdentity master_;

				// Token: 0x04001B72 RID: 7026
				private static FighterIdentity.Types.Companion WjsoKVGPJJS1sAFnsedx;
			}

			// Token: 0x02000653 RID: 1619
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Summon : IMessage<FighterIdentity.Types.Summon>, IMessage, IEquatable<FighterIdentity.Types.Summon>, IDeepCloneable<FighterIdentity.Types.Summon>, IBufferMessage
			{
				// Token: 0x17000E30 RID: 3632
				// (get) Token: 0x06004E86 RID: 20102 RVA: 0x00302838 File Offset: 0x00300A38
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<FighterIdentity.Types.Summon> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000E31 RID: 3633
				// (get) Token: 0x06004E87 RID: 20103 RVA: 0x00302848 File Offset: 0x00300A48
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

				// Token: 0x17000E32 RID: 3634
				// (get) Token: 0x06004E88 RID: 20104 RVA: 0x00302858 File Offset: 0x00300A58
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

				// Token: 0x06004E89 RID: 20105 RVA: 0x00302868 File Offset: 0x00300A68
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Summon()
				{
				}

				// Token: 0x06004E8A RID: 20106 RVA: 0x00302878 File Offset: 0x00300A78
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Summon(FighterIdentity.Types.Summon other)
				{
				}

				// Token: 0x06004E8B RID: 20107 RVA: 0x00302888 File Offset: 0x00300A88
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FighterIdentity.Types.Summon Clone()
				{
					return null;
				}

				// Token: 0x17000E33 RID: 3635
				// (get) Token: 0x06004E8C RID: 20108 RVA: 0x00302898 File Offset: 0x00300A98
				// (set) Token: 0x06004E8D RID: 20109 RVA: 0x003028A8 File Offset: 0x00300AA8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int MonsterId
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

				// Token: 0x17000E34 RID: 3636
				// (get) Token: 0x06004E8E RID: 20110 RVA: 0x003028B8 File Offset: 0x00300AB8
				// (set) Token: 0x06004E8F RID: 20111 RVA: 0x003028C8 File Offset: 0x00300AC8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public FighterIdentity Summoner
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

				// Token: 0x06004E90 RID: 20112 RVA: 0x003028D8 File Offset: 0x00300AD8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004E91 RID: 20113 RVA: 0x003028E8 File Offset: 0x00300AE8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(FighterIdentity.Types.Summon other)
				{
					return true;
				}

				// Token: 0x06004E92 RID: 20114 RVA: 0x003028F8 File Offset: 0x00300AF8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004E93 RID: 20115 RVA: 0x00302908 File Offset: 0x00300B08
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004E94 RID: 20116 RVA: 0x00302918 File Offset: 0x00300B18
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004E95 RID: 20117 RVA: 0x00302928 File Offset: 0x00300B28
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004E96 RID: 20118 RVA: 0x00302938 File Offset: 0x00300B38
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004E97 RID: 20119 RVA: 0x00302948 File Offset: 0x00300B48
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(FighterIdentity.Types.Summon other)
				{
				}

				// Token: 0x06004E98 RID: 20120 RVA: 0x00302958 File Offset: 0x00300B58
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004E99 RID: 20121 RVA: 0x00302968 File Offset: 0x00300B68
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004E9A RID: 20122 RVA: 0x00302978 File Offset: 0x00300B78
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Summon()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							FighterIdentity.Types.Summon._parser = new MessageParser<FighterIdentity.Types.Summon>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
							{
								num2 = 4;
							}
							break;
						case 1:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
							{
								num2 = 0;
							}
							break;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							break;
						case 4:
							return;
						}
					}
				}

				// Token: 0x06004E9B RID: 20123 RVA: 0x00302A5C File Offset: 0x00300C5C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool KKdjpaGPdgyM9M1VOolS()
				{
					return true;
				}

				// Token: 0x06004E9C RID: 20124 RVA: 0x00302A64 File Offset: 0x00300C64
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static FighterIdentity.Types.Summon wRJGoEGP9ixrE4dal698()
				{
					return null;
				}

				// Token: 0x04001B75 RID: 7029
				private static readonly MessageParser<FighterIdentity.Types.Summon> _parser;

				// Token: 0x04001B76 RID: 7030
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001B77 RID: 7031
				public const int MonsterIdFieldNumber = 1;

				// Token: 0x04001B78 RID: 7032
				private int monsterId_;

				// Token: 0x04001B79 RID: 7033
				public const int SummonerFieldNumber = 2;

				// Token: 0x04001B7A RID: 7034
				private FighterIdentity summoner_;

				// Token: 0x04001B7B RID: 7035
				private static FighterIdentity.Types.Summon FwrT2IGPspXdBcsQLCum;
			}
		}
	}
}
