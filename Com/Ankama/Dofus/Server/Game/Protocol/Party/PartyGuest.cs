using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x02000304 RID: 772
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyGuest : IMessage<PartyGuest>, IMessage, IEquatable<PartyGuest>, IDeepCloneable<PartyGuest>, IBufferMessage
	{
		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06002426 RID: 9254 RVA: 0x001BE98C File Offset: 0x001BCB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyGuest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x001BE99C File Offset: 0x001BCB9C
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

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06002428 RID: 9256 RVA: 0x001BE9AC File Offset: 0x001BCBAC
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

		// Token: 0x06002429 RID: 9257 RVA: 0x001BE9BC File Offset: 0x001BCBBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyGuest()
		{
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x001BE9CC File Offset: 0x001BCBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyGuest(PartyGuest other)
		{
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x001BE9DC File Offset: 0x001BCBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyGuest Clone()
		{
			return null;
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600242C RID: 9260 RVA: 0x001BE9EC File Offset: 0x001BCBEC
		// (set) Token: 0x0600242D RID: 9261 RVA: 0x001BE9FC File Offset: 0x001BCBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerId
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

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x0600242E RID: 9262 RVA: 0x001BEA0C File Offset: 0x001BCC0C
		// (set) Token: 0x0600242F RID: 9263 RVA: 0x001BEA1C File Offset: 0x001BCC1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long HostId
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

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06002430 RID: 9264 RVA: 0x001BEA2C File Offset: 0x001BCC2C
		// (set) Token: 0x06002431 RID: 9265 RVA: 0x001BEA3C File Offset: 0x001BCC3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06002432 RID: 9266 RVA: 0x001BEA4C File Offset: 0x001BCC4C
		// (set) Token: 0x06002433 RID: 9267 RVA: 0x001BEA5C File Offset: 0x001BCC5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public EntityLook Look
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

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06002434 RID: 9268 RVA: 0x001BEA6C File Offset: 0x001BCC6C
		// (set) Token: 0x06002435 RID: 9269 RVA: 0x001BEA7C File Offset: 0x001BCC7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Breed
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

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06002436 RID: 9270 RVA: 0x001BEA8C File Offset: 0x001BCC8C
		// (set) Token: 0x06002437 RID: 9271 RVA: 0x001BEAA0 File Offset: 0x001BCCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Gender Gender
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Gender)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06002438 RID: 9272 RVA: 0x001BEAB0 File Offset: 0x001BCCB0
		// (set) Token: 0x06002439 RID: 9273 RVA: 0x001BEAC0 File Offset: 0x001BCCC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterStatus Status
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

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x0600243A RID: 9274 RVA: 0x001BEAD0 File Offset: 0x001BCCD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<PartyEntity> Entities
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x001BEAE0 File Offset: 0x001BCCE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x001BEAF0 File Offset: 0x001BCCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyGuest other)
		{
			return true;
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x001BEB00 File Offset: 0x001BCD00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x001BEB10 File Offset: 0x001BCD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x001BEB20 File Offset: 0x001BCD20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x001BEB30 File Offset: 0x001BCD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x001BEB40 File Offset: 0x001BCD40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x001BEB50 File Offset: 0x001BCD50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyGuest other)
		{
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x001BEB60 File Offset: 0x001BCD60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x001BEB70 File Offset: 0x001BCD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x001BEB80 File Offset: 0x001BCD80
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyGuest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						continue;
					case 5:
						PartyGuest._repeated_entities_codec = FieldCodec.ForMessage<PartyEntity>(66U, cYYvTcn1ExwQJEKZCPPn.XVInXhlssT(cYYvTcn1ExwQJEKZCPPn.zJSn1Xk8R1C));
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					break;
				}
				IL_8C:
				PartyGuest._parser = new MessageParser<PartyGuest>(() => null);
				num = 5;
				continue;
				goto IL_8C;
			}
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x001BEC8C File Offset: 0x001BCE8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KUwdGGOLS4jlhSmEJ5Vj()
		{
			return true;
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x001BEC94 File Offset: 0x001BCE94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyGuest uctWKfOLMqHyV1FncPDf()
		{
			return null;
		}

		// Token: 0x04000CD5 RID: 3285
		private static readonly MessageParser<PartyGuest> _parser;

		// Token: 0x04000CD6 RID: 3286
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CD7 RID: 3287
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04000CD8 RID: 3288
		private long playerId_;

		// Token: 0x04000CD9 RID: 3289
		public const int HostIdFieldNumber = 2;

		// Token: 0x04000CDA RID: 3290
		private long hostId_;

		// Token: 0x04000CDB RID: 3291
		public const int NameFieldNumber = 3;

		// Token: 0x04000CDC RID: 3292
		private string name_;

		// Token: 0x04000CDD RID: 3293
		public const int LookFieldNumber = 4;

		// Token: 0x04000CDE RID: 3294
		private EntityLook look_;

		// Token: 0x04000CDF RID: 3295
		public const int BreedFieldNumber = 5;

		// Token: 0x04000CE0 RID: 3296
		private int breed_;

		// Token: 0x04000CE1 RID: 3297
		public const int GenderFieldNumber = 6;

		// Token: 0x04000CE2 RID: 3298
		private Gender gender_;

		// Token: 0x04000CE3 RID: 3299
		public const int StatusFieldNumber = 7;

		// Token: 0x04000CE4 RID: 3300
		private CharacterStatus status_;

		// Token: 0x04000CE5 RID: 3301
		public const int EntitiesFieldNumber = 8;

		// Token: 0x04000CE6 RID: 3302
		private static readonly FieldCodec<PartyEntity> _repeated_entities_codec;

		// Token: 0x04000CE7 RID: 3303
		private readonly RepeatedField<PartyEntity> entities_;

		// Token: 0x04000CE8 RID: 3304
		private static PartyGuest vc8499OLPBVRsWkahjx3;
	}
}
