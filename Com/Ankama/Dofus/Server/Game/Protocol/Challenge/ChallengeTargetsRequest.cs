using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge
{
	// Token: 0x0200094A RID: 2378
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeTargetsRequest : IMessage<ChallengeTargetsRequest>, IMessage, IEquatable<ChallengeTargetsRequest>, IDeepCloneable<ChallengeTargetsRequest>, IBufferMessage
	{
		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x06007313 RID: 29459 RVA: 0x0023F06C File Offset: 0x0023D26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeTargetsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x06007314 RID: 29460 RVA: 0x0023F07C File Offset: 0x0023D27C
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

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x06007315 RID: 29461 RVA: 0x0023F08C File Offset: 0x0023D28C
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

		// Token: 0x06007316 RID: 29462 RVA: 0x0023F09C File Offset: 0x0023D29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeTargetsRequest()
		{
		}

		// Token: 0x06007317 RID: 29463 RVA: 0x0023F0AC File Offset: 0x0023D2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeTargetsRequest(ChallengeTargetsRequest other)
		{
		}

		// Token: 0x06007318 RID: 29464 RVA: 0x0023F0BC File Offset: 0x0023D2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeTargetsRequest Clone()
		{
			return null;
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x06007319 RID: 29465 RVA: 0x0023F0CC File Offset: 0x0023D2CC
		// (set) Token: 0x0600731A RID: 29466 RVA: 0x0023F0DC File Offset: 0x0023D2DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ChallengeId
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

		// Token: 0x0600731B RID: 29467 RVA: 0x0023F0EC File Offset: 0x0023D2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600731C RID: 29468 RVA: 0x0023F0FC File Offset: 0x0023D2FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChallengeTargetsRequest other)
		{
			return true;
		}

		// Token: 0x0600731D RID: 29469 RVA: 0x0023F10C File Offset: 0x0023D30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600731E RID: 29470 RVA: 0x0023F11C File Offset: 0x0023D31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600731F RID: 29471 RVA: 0x0023F12C File Offset: 0x0023D32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007320 RID: 29472 RVA: 0x0023F13C File Offset: 0x0023D33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007321 RID: 29473 RVA: 0x0023F14C File Offset: 0x0023D34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007322 RID: 29474 RVA: 0x0023F15C File Offset: 0x0023D35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChallengeTargetsRequest other)
		{
		}

		// Token: 0x06007323 RID: 29475 RVA: 0x0023F16C File Offset: 0x0023D36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007324 RID: 29476 RVA: 0x0023F17C File Offset: 0x0023D37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007325 RID: 29477 RVA: 0x0023F18C File Offset: 0x0023D38C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChallengeTargetsRequest()
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
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						ChallengeTargetsRequest._parser = new MessageParser<ChallengeTargetsRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_5F;
					}
					return;
				}
				IL_5F:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 3;
			}
		}

		// Token: 0x06007326 RID: 29478 RVA: 0x0023F274 File Offset: 0x0023D474
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CcIeqrJ324eeCLGYlqIO()
		{
			return true;
		}

		// Token: 0x06007327 RID: 29479 RVA: 0x0023F27C File Offset: 0x0023D47C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChallengeTargetsRequest WH5T59J3E4bM6uARqkQL()
		{
			return null;
		}

		// Token: 0x0400283E RID: 10302
		private static readonly MessageParser<ChallengeTargetsRequest> _parser;

		// Token: 0x0400283F RID: 10303
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002840 RID: 10304
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04002841 RID: 10305
		private int challengeId_;

		// Token: 0x04002842 RID: 10306
		private static ChallengeTargetsRequest ru4I4aJ390sT84MwFiIp;
	}
}
