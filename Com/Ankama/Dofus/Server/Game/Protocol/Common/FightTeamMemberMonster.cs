using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000AB6 RID: 2742
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTeamMemberMonster : IMessage<FightTeamMemberMonster>, IMessage, IEquatable<FightTeamMemberMonster>, IDeepCloneable<FightTeamMemberMonster>, IBufferMessage
	{
		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x06008314 RID: 33556 RVA: 0x00262F20 File Offset: 0x00261120
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightTeamMemberMonster> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x06008315 RID: 33557 RVA: 0x00262F30 File Offset: 0x00261130
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

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x06008316 RID: 33558 RVA: 0x00262F40 File Offset: 0x00261140
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

		// Token: 0x06008317 RID: 33559 RVA: 0x00262F50 File Offset: 0x00261150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamMemberMonster()
		{
		}

		// Token: 0x06008318 RID: 33560 RVA: 0x00262F60 File Offset: 0x00261160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamMemberMonster(FightTeamMemberMonster other)
		{
		}

		// Token: 0x06008319 RID: 33561 RVA: 0x00262F70 File Offset: 0x00261170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamMemberMonster Clone()
		{
			return null;
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x0600831A RID: 33562 RVA: 0x00262F80 File Offset: 0x00261180
		// (set) Token: 0x0600831B RID: 33563 RVA: 0x00262F90 File Offset: 0x00261190
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

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x0600831C RID: 33564 RVA: 0x00262FA0 File Offset: 0x002611A0
		// (set) Token: 0x0600831D RID: 33565 RVA: 0x00262FB0 File Offset: 0x002611B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Grade
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

		// Token: 0x0600831E RID: 33566 RVA: 0x00262FC0 File Offset: 0x002611C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600831F RID: 33567 RVA: 0x00262FD0 File Offset: 0x002611D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTeamMemberMonster other)
		{
			return true;
		}

		// Token: 0x06008320 RID: 33568 RVA: 0x00262FE0 File Offset: 0x002611E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008321 RID: 33569 RVA: 0x00262FF0 File Offset: 0x002611F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008322 RID: 33570 RVA: 0x00263000 File Offset: 0x00261200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008323 RID: 33571 RVA: 0x00263010 File Offset: 0x00261210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008324 RID: 33572 RVA: 0x00263020 File Offset: 0x00261220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008325 RID: 33573 RVA: 0x00263030 File Offset: 0x00261230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTeamMemberMonster other)
		{
		}

		// Token: 0x06008326 RID: 33574 RVA: 0x00263040 File Offset: 0x00261240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008327 RID: 33575 RVA: 0x00263050 File Offset: 0x00261250
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008328 RID: 33576 RVA: 0x00263060 File Offset: 0x00261260
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTeamMemberMonster()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					FightTeamMemberMonster._parser = new MessageParser<FightTeamMemberMonster>(() => null);
					num2 = 4;
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x06008329 RID: 33577 RVA: 0x0026312C File Offset: 0x0026132C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H2h0I9JssQBcxTpGpJk2()
		{
			return true;
		}

		// Token: 0x0600832A RID: 33578 RVA: 0x00263134 File Offset: 0x00261334
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTeamMemberMonster PUBB2FJsdT1hKRMMGAf2()
		{
			return null;
		}

		// Token: 0x04002FC9 RID: 12233
		private static readonly MessageParser<FightTeamMemberMonster> _parser;

		// Token: 0x04002FCA RID: 12234
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FCB RID: 12235
		public const int MonsterIdFieldNumber = 1;

		// Token: 0x04002FCC RID: 12236
		private int monsterId_;

		// Token: 0x04002FCD RID: 12237
		public const int GradeFieldNumber = 2;

		// Token: 0x04002FCE RID: 12238
		private int grade_;

		// Token: 0x04002FCF RID: 12239
		internal static FightTeamMemberMonster zgYXcKJsgc0KfON9jHgc;
	}
}
