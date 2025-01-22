using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context
{
	// Token: 0x0200081D RID: 2077
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonsterBoosts : IMessage<MonsterBoosts>, IMessage, IEquatable<MonsterBoosts>, IDeepCloneable<MonsterBoosts>, IBufferMessage
	{
		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x06006509 RID: 25865 RVA: 0x0022767C File Offset: 0x0022587C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonsterBoosts> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x0600650A RID: 25866 RVA: 0x0022768C File Offset: 0x0022588C
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

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x0600650B RID: 25867 RVA: 0x0022769C File Offset: 0x0022589C
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

		// Token: 0x0600650C RID: 25868 RVA: 0x002276AC File Offset: 0x002258AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonsterBoosts()
		{
		}

		// Token: 0x0600650D RID: 25869 RVA: 0x002276BC File Offset: 0x002258BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonsterBoosts(MonsterBoosts other)
		{
		}

		// Token: 0x0600650E RID: 25870 RVA: 0x002276CC File Offset: 0x002258CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonsterBoosts Clone()
		{
			return null;
		}

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x0600650F RID: 25871 RVA: 0x002276DC File Offset: 0x002258DC
		// (set) Token: 0x06006510 RID: 25872 RVA: 0x002276EC File Offset: 0x002258EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x06006511 RID: 25873 RVA: 0x002276FC File Offset: 0x002258FC
		// (set) Token: 0x06006512 RID: 25874 RVA: 0x0022770C File Offset: 0x0022590C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int XpBoost
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

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x06006513 RID: 25875 RVA: 0x0022771C File Offset: 0x0022591C
		// (set) Token: 0x06006514 RID: 25876 RVA: 0x0022772C File Offset: 0x0022592C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DropBoost
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

		// Token: 0x06006515 RID: 25877 RVA: 0x0022773C File Offset: 0x0022593C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006516 RID: 25878 RVA: 0x0022774C File Offset: 0x0022594C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MonsterBoosts other)
		{
			return true;
		}

		// Token: 0x06006517 RID: 25879 RVA: 0x0022775C File Offset: 0x0022595C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006518 RID: 25880 RVA: 0x0022776C File Offset: 0x0022596C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006519 RID: 25881 RVA: 0x0022777C File Offset: 0x0022597C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600651A RID: 25882 RVA: 0x0022778C File Offset: 0x0022598C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600651B RID: 25883 RVA: 0x0022779C File Offset: 0x0022599C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600651C RID: 25884 RVA: 0x002277AC File Offset: 0x002259AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MonsterBoosts other)
		{
		}

		// Token: 0x0600651D RID: 25885 RVA: 0x002277BC File Offset: 0x002259BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600651E RID: 25886 RVA: 0x002277CC File Offset: 0x002259CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600651F RID: 25887 RVA: 0x002277DC File Offset: 0x002259DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MonsterBoosts()
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
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					MonsterBoosts._parser = new MessageParser<MonsterBoosts>(() => null);
					num2 = 2;
					break;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x06006520 RID: 25888 RVA: 0x002278A8 File Offset: 0x00225AA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool s9hmhMJff3p9aIZwnaI6()
		{
			return true;
		}

		// Token: 0x06006521 RID: 25889 RVA: 0x002278B0 File Offset: 0x00225AB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MonsterBoosts LdvNMVJfnXC6QVYmD9GI()
		{
			return null;
		}

		// Token: 0x04002376 RID: 9078
		private static readonly MessageParser<MonsterBoosts> _parser;

		// Token: 0x04002377 RID: 9079
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002378 RID: 9080
		public const int IdFieldNumber = 1;

		// Token: 0x04002379 RID: 9081
		private int id_;

		// Token: 0x0400237A RID: 9082
		public const int XpBoostFieldNumber = 2;

		// Token: 0x0400237B RID: 9083
		private int xpBoost_;

		// Token: 0x0400237C RID: 9084
		public const int DropBoostFieldNumber = 3;

		// Token: 0x0400237D RID: 9085
		private int dropBoost_;

		// Token: 0x0400237E RID: 9086
		internal static MonsterBoosts k2i8N8OzzWOCg4bMgxob;
	}
}
