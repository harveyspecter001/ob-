using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A4D RID: 2637
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyEntity : IMessage<PartyEntity>, IMessage, IEquatable<PartyEntity>, IDeepCloneable<PartyEntity>, IBufferMessage
	{
		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x06007DAD RID: 32173 RVA: 0x0025D284 File Offset: 0x0025B484
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PartyEntity> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x06007DAE RID: 32174 RVA: 0x0025D294 File Offset: 0x0025B494
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

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x06007DAF RID: 32175 RVA: 0x0025D2A4 File Offset: 0x0025B4A4
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

		// Token: 0x06007DB0 RID: 32176 RVA: 0x0025D2B4 File Offset: 0x0025B4B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyEntity()
		{
		}

		// Token: 0x06007DB1 RID: 32177 RVA: 0x0025D2C4 File Offset: 0x0025B4C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyEntity(PartyEntity other)
		{
		}

		// Token: 0x06007DB2 RID: 32178 RVA: 0x0025D2D4 File Offset: 0x0025B4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyEntity Clone()
		{
			return null;
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x06007DB3 RID: 32179 RVA: 0x0025D2E4 File Offset: 0x0025B4E4
		// (set) Token: 0x06007DB4 RID: 32180 RVA: 0x0025D2F4 File Offset: 0x0025B4F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int IndexId
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

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x06007DB5 RID: 32181 RVA: 0x0025D304 File Offset: 0x0025B504
		// (set) Token: 0x06007DB6 RID: 32182 RVA: 0x0025D314 File Offset: 0x0025B514
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x06007DB7 RID: 32183 RVA: 0x0025D324 File Offset: 0x0025B524
		// (set) Token: 0x06007DB8 RID: 32184 RVA: 0x0025D334 File Offset: 0x0025B534
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

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x06007DB9 RID: 32185 RVA: 0x0025D344 File Offset: 0x0025B544
		// (set) Token: 0x06007DBA RID: 32186 RVA: 0x0025D354 File Offset: 0x0025B554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartyEntity.Types.EntityMember EntityMember
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

		// Token: 0x06007DBB RID: 32187 RVA: 0x0025D364 File Offset: 0x0025B564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007DBC RID: 32188 RVA: 0x0025D374 File Offset: 0x0025B574
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyEntity other)
		{
			return true;
		}

		// Token: 0x06007DBD RID: 32189 RVA: 0x0025D384 File Offset: 0x0025B584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007DBE RID: 32190 RVA: 0x0025D394 File Offset: 0x0025B594
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007DBF RID: 32191 RVA: 0x0025D3A4 File Offset: 0x0025B5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007DC0 RID: 32192 RVA: 0x0025D3B4 File Offset: 0x0025B5B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007DC1 RID: 32193 RVA: 0x0025D3C4 File Offset: 0x0025B5C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007DC2 RID: 32194 RVA: 0x0025D3D4 File Offset: 0x0025B5D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyEntity other)
		{
		}

		// Token: 0x06007DC3 RID: 32195 RVA: 0x0025D3E4 File Offset: 0x0025B5E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007DC4 RID: 32196 RVA: 0x0025D3F4 File Offset: 0x0025B5F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007DC5 RID: 32197 RVA: 0x0025D404 File Offset: 0x0025B604
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyEntity()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				PartyEntity._parser = new MessageParser<PartyEntity>(() => null);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06007DC6 RID: 32198 RVA: 0x0025D4FC File Offset: 0x0025B6FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TlG4hnJGvJdWkWHYSGF4()
		{
			return true;
		}

		// Token: 0x06007DC7 RID: 32199 RVA: 0x0025D504 File Offset: 0x0025B704
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyEntity FDlCYkJGoaAmD7XBWAdV()
		{
			return null;
		}

		// Token: 0x04002D61 RID: 11617
		private static readonly MessageParser<PartyEntity> _parser;

		// Token: 0x04002D62 RID: 11618
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D63 RID: 11619
		public const int IndexIdFieldNumber = 1;

		// Token: 0x04002D64 RID: 11620
		private int indexId_;

		// Token: 0x04002D65 RID: 11621
		public const int EntityModelIdFieldNumber = 2;

		// Token: 0x04002D66 RID: 11622
		private int entityModelId_;

		// Token: 0x04002D67 RID: 11623
		public const int LookFieldNumber = 3;

		// Token: 0x04002D68 RID: 11624
		private EntityLook look_;

		// Token: 0x04002D69 RID: 11625
		public const int EntityMemberFieldNumber = 4;

		// Token: 0x04002D6A RID: 11626
		private PartyEntity.Types.EntityMember entityMember_;

		// Token: 0x04002D6B RID: 11627
		internal static PartyEntity n1ib1WJGUidrxwXTGgOQ;

		// Token: 0x02000A4E RID: 2638
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06007DC8 RID: 32200 RVA: 0x002DF5E8 File Offset: 0x002DD7E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000A4F RID: 2639
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class EntityMember : IMessage<PartyEntity.Types.EntityMember>, IMessage, IEquatable<PartyEntity.Types.EntityMember>, IDeepCloneable<PartyEntity.Types.EntityMember>, IBufferMessage
			{
				// Token: 0x170016D1 RID: 5841
				// (get) Token: 0x06007DC9 RID: 32201 RVA: 0x00307BD4 File Offset: 0x00305DD4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<PartyEntity.Types.EntityMember> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170016D2 RID: 5842
				// (get) Token: 0x06007DCA RID: 32202 RVA: 0x00307BE4 File Offset: 0x00305DE4
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

				// Token: 0x170016D3 RID: 5843
				// (get) Token: 0x06007DCB RID: 32203 RVA: 0x00307BF4 File Offset: 0x00305DF4
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

				// Token: 0x06007DCC RID: 32204 RVA: 0x00307C04 File Offset: 0x00305E04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public EntityMember()
				{
				}

				// Token: 0x06007DCD RID: 32205 RVA: 0x00307C14 File Offset: 0x00305E14
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public EntityMember(PartyEntity.Types.EntityMember other)
				{
				}

				// Token: 0x06007DCE RID: 32206 RVA: 0x00307C24 File Offset: 0x00305E24
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PartyEntity.Types.EntityMember Clone()
				{
					return null;
				}

				// Token: 0x170016D4 RID: 5844
				// (get) Token: 0x06007DCF RID: 32207 RVA: 0x00307C34 File Offset: 0x00305E34
				// (set) Token: 0x06007DD0 RID: 32208 RVA: 0x00307C44 File Offset: 0x00305E44
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Initiative
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

				// Token: 0x170016D5 RID: 5845
				// (get) Token: 0x06007DD1 RID: 32209 RVA: 0x00307C54 File Offset: 0x00305E54
				// (set) Token: 0x06007DD2 RID: 32210 RVA: 0x00307C64 File Offset: 0x00305E64
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public PartyUpdateCommonsInformation CommonsInformation
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

				// Token: 0x06007DD3 RID: 32211 RVA: 0x00307C74 File Offset: 0x00305E74
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06007DD4 RID: 32212 RVA: 0x00307C84 File Offset: 0x00305E84
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PartyEntity.Types.EntityMember other)
				{
					return true;
				}

				// Token: 0x06007DD5 RID: 32213 RVA: 0x00307C94 File Offset: 0x00305E94
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06007DD6 RID: 32214 RVA: 0x00307CA4 File Offset: 0x00305EA4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06007DD7 RID: 32215 RVA: 0x00307CB4 File Offset: 0x00305EB4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06007DD8 RID: 32216 RVA: 0x00307CC4 File Offset: 0x00305EC4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06007DD9 RID: 32217 RVA: 0x00307CD4 File Offset: 0x00305ED4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06007DDA RID: 32218 RVA: 0x00307CE4 File Offset: 0x00305EE4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PartyEntity.Types.EntityMember other)
				{
				}

				// Token: 0x06007DDB RID: 32219 RVA: 0x00307CF4 File Offset: 0x00305EF4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06007DDC RID: 32220 RVA: 0x00307D04 File Offset: 0x00305F04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06007DDD RID: 32221 RVA: 0x00307D14 File Offset: 0x00305F14
				[MethodImpl(MethodImplOptions.NoInlining)]
				static EntityMember()
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
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 != 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							return;
						}
						PartyEntity.Types.EntityMember._parser = new MessageParser<PartyEntity.Types.EntityMember>(() => null);
						num2 = 4;
					}
				}

				// Token: 0x06007DDE RID: 32222 RVA: 0x00307DF8 File Offset: 0x00305FF8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool vLS53oGuRu3BNNQbAqSj()
				{
					return true;
				}

				// Token: 0x06007DDF RID: 32223 RVA: 0x00307E00 File Offset: 0x00306000
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PartyEntity.Types.EntityMember cAKsqpGuObn3V8ONqaEI()
				{
					return null;
				}

				// Token: 0x04002D6C RID: 11628
				private static readonly MessageParser<PartyEntity.Types.EntityMember> _parser;

				// Token: 0x04002D6D RID: 11629
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002D6E RID: 11630
				public const int InitiativeFieldNumber = 1;

				// Token: 0x04002D6F RID: 11631
				private int initiative_;

				// Token: 0x04002D70 RID: 11632
				public const int CommonsInformationFieldNumber = 2;

				// Token: 0x04002D71 RID: 11633
				private PartyUpdateCommonsInformation commonsInformation_;

				// Token: 0x04002D72 RID: 11634
				private static PartyEntity.Types.EntityMember GPFJetGu3ZBM7EGyy6O8;
			}
		}
	}
}
