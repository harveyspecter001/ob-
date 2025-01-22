using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000AB4 RID: 2740
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTeamMemberEntity : IMessage<FightTeamMemberEntity>, IMessage, IEquatable<FightTeamMemberEntity>, IDeepCloneable<FightTeamMemberEntity>, IBufferMessage
	{
		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x060082F6 RID: 33526 RVA: 0x00262CCC File Offset: 0x00260ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightTeamMemberEntity> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x060082F7 RID: 33527 RVA: 0x00262CDC File Offset: 0x00260EDC
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

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x060082F8 RID: 33528 RVA: 0x00262CEC File Offset: 0x00260EEC
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

		// Token: 0x060082F9 RID: 33529 RVA: 0x00262CFC File Offset: 0x00260EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamMemberEntity()
		{
		}

		// Token: 0x060082FA RID: 33530 RVA: 0x00262D0C File Offset: 0x00260F0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamMemberEntity(FightTeamMemberEntity other)
		{
		}

		// Token: 0x060082FB RID: 33531 RVA: 0x00262D1C File Offset: 0x00260F1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTeamMemberEntity Clone()
		{
			return null;
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x060082FC RID: 33532 RVA: 0x00262D2C File Offset: 0x00260F2C
		// (set) Token: 0x060082FD RID: 33533 RVA: 0x00262D3C File Offset: 0x00260F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityModelId
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

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x060082FE RID: 33534 RVA: 0x00262D4C File Offset: 0x00260F4C
		// (set) Token: 0x060082FF RID: 33535 RVA: 0x00262D5C File Offset: 0x00260F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
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

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x06008300 RID: 33536 RVA: 0x00262D6C File Offset: 0x00260F6C
		// (set) Token: 0x06008301 RID: 33537 RVA: 0x00262D7C File Offset: 0x00260F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MasterId
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

		// Token: 0x06008302 RID: 33538 RVA: 0x00262D8C File Offset: 0x00260F8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008303 RID: 33539 RVA: 0x00262D9C File Offset: 0x00260F9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTeamMemberEntity other)
		{
			return true;
		}

		// Token: 0x06008304 RID: 33540 RVA: 0x00262DAC File Offset: 0x00260FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008305 RID: 33541 RVA: 0x00262DBC File Offset: 0x00260FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008306 RID: 33542 RVA: 0x00262DCC File Offset: 0x00260FCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008307 RID: 33543 RVA: 0x00262DDC File Offset: 0x00260FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008308 RID: 33544 RVA: 0x00262DEC File Offset: 0x00260FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008309 RID: 33545 RVA: 0x00262DFC File Offset: 0x00260FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTeamMemberEntity other)
		{
		}

		// Token: 0x0600830A RID: 33546 RVA: 0x00262E0C File Offset: 0x0026100C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600830B RID: 33547 RVA: 0x00262E1C File Offset: 0x0026101C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600830C RID: 33548 RVA: 0x00262E2C File Offset: 0x0026102C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTeamMemberEntity()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
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
					continue;
				case 4:
					FightTeamMemberEntity._parser = new MessageParser<FightTeamMemberEntity>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b != 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x0600830D RID: 33549 RVA: 0x00262F10 File Offset: 0x00261110
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool y5fGU3JsJlxilxELauR3()
		{
			return true;
		}

		// Token: 0x0600830E RID: 33550 RVA: 0x00262F18 File Offset: 0x00261118
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTeamMemberEntity Nn0hn3JsGk87g4MNPsnX()
		{
			return null;
		}

		// Token: 0x04002FBE RID: 12222
		private static readonly MessageParser<FightTeamMemberEntity> _parser;

		// Token: 0x04002FBF RID: 12223
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FC0 RID: 12224
		public const int EntityModelIdFieldNumber = 1;

		// Token: 0x04002FC1 RID: 12225
		private int entityModelId_;

		// Token: 0x04002FC2 RID: 12226
		public const int LevelFieldNumber = 2;

		// Token: 0x04002FC3 RID: 12227
		private int level_;

		// Token: 0x04002FC4 RID: 12228
		public const int MasterIdFieldNumber = 3;

		// Token: 0x04002FC5 RID: 12229
		private long masterId_;

		// Token: 0x04002FC6 RID: 12230
		private static FightTeamMemberEntity bi2LLJJsO1SXM0Uoh5Vu;
	}
}
