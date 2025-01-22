using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge
{
	// Token: 0x02000954 RID: 2388
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeBonusChoiceRequest : IMessage<ChallengeBonusChoiceRequest>, IMessage, IEquatable<ChallengeBonusChoiceRequest>, IDeepCloneable<ChallengeBonusChoiceRequest>, IBufferMessage
	{
		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x06007395 RID: 29589 RVA: 0x0023FAAC File Offset: 0x0023DCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeBonusChoiceRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x06007396 RID: 29590 RVA: 0x0023FABC File Offset: 0x0023DCBC
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

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x06007397 RID: 29591 RVA: 0x0023FACC File Offset: 0x0023DCCC
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

		// Token: 0x06007398 RID: 29592 RVA: 0x0023FADC File Offset: 0x0023DCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeBonusChoiceRequest()
		{
		}

		// Token: 0x06007399 RID: 29593 RVA: 0x0023FAEC File Offset: 0x0023DCEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeBonusChoiceRequest(ChallengeBonusChoiceRequest other)
		{
		}

		// Token: 0x0600739A RID: 29594 RVA: 0x0023FAFC File Offset: 0x0023DCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeBonusChoiceRequest Clone()
		{
			return null;
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x0600739B RID: 29595 RVA: 0x0023FB0C File Offset: 0x0023DD0C
		// (set) Token: 0x0600739C RID: 29596 RVA: 0x0023FB20 File Offset: 0x0023DD20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ChallengeBonus ChallengeBonus
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ChallengeBonus)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600739D RID: 29597 RVA: 0x0023FB30 File Offset: 0x0023DD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600739E RID: 29598 RVA: 0x0023FB40 File Offset: 0x0023DD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChallengeBonusChoiceRequest other)
		{
			return true;
		}

		// Token: 0x0600739F RID: 29599 RVA: 0x0023FB50 File Offset: 0x0023DD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060073A0 RID: 29600 RVA: 0x0023FB60 File Offset: 0x0023DD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060073A1 RID: 29601 RVA: 0x0023FB70 File Offset: 0x0023DD70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060073A2 RID: 29602 RVA: 0x0023FB80 File Offset: 0x0023DD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060073A3 RID: 29603 RVA: 0x0023FB90 File Offset: 0x0023DD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060073A4 RID: 29604 RVA: 0x0023FBA0 File Offset: 0x0023DDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChallengeBonusChoiceRequest other)
		{
		}

		// Token: 0x060073A5 RID: 29605 RVA: 0x0023FBB0 File Offset: 0x0023DDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060073A6 RID: 29606 RVA: 0x0023FBC0 File Offset: 0x0023DDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060073A7 RID: 29607 RVA: 0x0023FBD0 File Offset: 0x0023DDD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChallengeBonusChoiceRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					ChallengeBonusChoiceRequest._parser = new MessageParser<ChallengeBonusChoiceRequest>(() => null);
					num2 = 3;
					break;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x060073A8 RID: 29608 RVA: 0x0023FC9C File Offset: 0x0023DE9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hCgDXbJ31uqmfy6jTlO4()
		{
			return true;
		}

		// Token: 0x060073A9 RID: 29609 RVA: 0x0023FCA4 File Offset: 0x0023DEA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChallengeBonusChoiceRequest rIMNQxJ3asx8wFYDa6WE()
		{
			return null;
		}

		// Token: 0x04002861 RID: 10337
		private static readonly MessageParser<ChallengeBonusChoiceRequest> _parser;

		// Token: 0x04002862 RID: 10338
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002863 RID: 10339
		public const int ChallengeBonusFieldNumber = 1;

		// Token: 0x04002864 RID: 10340
		private ChallengeBonus challengeBonus_;

		// Token: 0x04002865 RID: 10341
		private static ChallengeBonusChoiceRequest JZi9cmJ3o6Nx1l32gZW6;
	}
}
