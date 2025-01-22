using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Rank
{
	// Token: 0x02000D23 RID: 3363
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceRankCreationRequest : IMessage<AllianceRankCreationRequest>, IMessage, IEquatable<AllianceRankCreationRequest>, IDeepCloneable<AllianceRankCreationRequest>, IBufferMessage
	{
		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x0600A1E4 RID: 41444 RVA: 0x00289FB0 File Offset: 0x002881B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceRankCreationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x0600A1E5 RID: 41445 RVA: 0x00289FC0 File Offset: 0x002881C0
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

		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x0600A1E6 RID: 41446 RVA: 0x00289FD0 File Offset: 0x002881D0
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

		// Token: 0x0600A1E7 RID: 41447 RVA: 0x00289FE0 File Offset: 0x002881E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRankCreationRequest()
		{
		}

		// Token: 0x0600A1E8 RID: 41448 RVA: 0x00289FF0 File Offset: 0x002881F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRankCreationRequest(AllianceRankCreationRequest other)
		{
		}

		// Token: 0x0600A1E9 RID: 41449 RVA: 0x0028A000 File Offset: 0x00288200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRankCreationRequest Clone()
		{
			return null;
		}

		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x0600A1EA RID: 41450 RVA: 0x0028A010 File Offset: 0x00288210
		// (set) Token: 0x0600A1EB RID: 41451 RVA: 0x0028A020 File Offset: 0x00288220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ParentRankId
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

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x0600A1EC RID: 41452 RVA: 0x0028A030 File Offset: 0x00288230
		// (set) Token: 0x0600A1ED RID: 41453 RVA: 0x0028A040 File Offset: 0x00288240
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int GfxId
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

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x0600A1EE RID: 41454 RVA: 0x0028A050 File Offset: 0x00288250
		// (set) Token: 0x0600A1EF RID: 41455 RVA: 0x0028A060 File Offset: 0x00288260
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

		// Token: 0x0600A1F0 RID: 41456 RVA: 0x0028A070 File Offset: 0x00288270
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A1F1 RID: 41457 RVA: 0x0028A080 File Offset: 0x00288280
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceRankCreationRequest other)
		{
			return true;
		}

		// Token: 0x0600A1F2 RID: 41458 RVA: 0x0028A090 File Offset: 0x00288290
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A1F3 RID: 41459 RVA: 0x0028A0A0 File Offset: 0x002882A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A1F4 RID: 41460 RVA: 0x0028A0B0 File Offset: 0x002882B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A1F5 RID: 41461 RVA: 0x0028A0C0 File Offset: 0x002882C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A1F6 RID: 41462 RVA: 0x0028A0D0 File Offset: 0x002882D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A1F7 RID: 41463 RVA: 0x0028A0E0 File Offset: 0x002882E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceRankCreationRequest other)
		{
		}

		// Token: 0x0600A1F8 RID: 41464 RVA: 0x0028A0F0 File Offset: 0x002882F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A1F9 RID: 41465 RVA: 0x0028A100 File Offset: 0x00288300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A1FA RID: 41466 RVA: 0x0028A110 File Offset: 0x00288310
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceRankCreationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AllianceRankCreationRequest._parser = new MessageParser<AllianceRankCreationRequest>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x0600A1FB RID: 41467 RVA: 0x0028A208 File Offset: 0x00288408
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RSILxuJKtGfdBA57rmyM()
		{
			return true;
		}

		// Token: 0x0600A1FC RID: 41468 RVA: 0x0028A210 File Offset: 0x00288410
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceRankCreationRequest g0rl1GJKwaxeWVko1FKL()
		{
			return null;
		}

		// Token: 0x04003BCD RID: 15309
		private static readonly MessageParser<AllianceRankCreationRequest> _parser;

		// Token: 0x04003BCE RID: 15310
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BCF RID: 15311
		public const int ParentRankIdFieldNumber = 1;

		// Token: 0x04003BD0 RID: 15312
		private int parentRankId_;

		// Token: 0x04003BD1 RID: 15313
		public const int GfxIdFieldNumber = 2;

		// Token: 0x04003BD2 RID: 15314
		private int gfxId_;

		// Token: 0x04003BD3 RID: 15315
		public const int NameFieldNumber = 3;

		// Token: 0x04003BD4 RID: 15316
		private string name_;

		// Token: 0x04003BD5 RID: 15317
		internal static AllianceRankCreationRequest iht75vJKDwMCUJHqREVR;
	}
}
