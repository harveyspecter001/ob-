using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x0200092D RID: 2349
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterSelectionEvent : IMessage<CharacterSelectionEvent>, IMessage, IEquatable<CharacterSelectionEvent>, IDeepCloneable<CharacterSelectionEvent>, IBufferMessage
	{
		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x060071D2 RID: 29138 RVA: 0x0023CFDC File Offset: 0x0023B1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterSelectionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x060071D3 RID: 29139 RVA: 0x0023CFEC File Offset: 0x0023B1EC
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

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x060071D4 RID: 29140 RVA: 0x0023CFFC File Offset: 0x0023B1FC
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

		// Token: 0x060071D5 RID: 29141 RVA: 0x0023D00C File Offset: 0x0023B20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterSelectionEvent()
		{
		}

		// Token: 0x060071D6 RID: 29142 RVA: 0x0023D01C File Offset: 0x0023B21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterSelectionEvent(CharacterSelectionEvent other)
		{
		}

		// Token: 0x060071D7 RID: 29143 RVA: 0x0023D02C File Offset: 0x0023B22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterSelectionEvent Clone()
		{
			return null;
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x060071D8 RID: 29144 RVA: 0x0023D03C File Offset: 0x0023B23C
		// (set) Token: 0x060071D9 RID: 29145 RVA: 0x0023D04C File Offset: 0x0023B24C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterSelectionEvent.Types.Error Error
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

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x060071DA RID: 29146 RVA: 0x0023D05C File Offset: 0x0023B25C
		// (set) Token: 0x060071DB RID: 29147 RVA: 0x0023D06C File Offset: 0x0023B26C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterSelectionEvent.Types.Success Success
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

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x060071DC RID: 29148 RVA: 0x0023D07C File Offset: 0x0023B27C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterSelectionEvent.ResultOneofCase ResultCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CharacterSelectionEvent.ResultOneofCase)null;
			}
		}

		// Token: 0x060071DD RID: 29149 RVA: 0x0023D090 File Offset: 0x0023B290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearResult()
		{
		}

		// Token: 0x060071DE RID: 29150 RVA: 0x0023D0A0 File Offset: 0x0023B2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060071DF RID: 29151 RVA: 0x0023D0B0 File Offset: 0x0023B2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterSelectionEvent other)
		{
			return true;
		}

		// Token: 0x060071E0 RID: 29152 RVA: 0x0023D0C0 File Offset: 0x0023B2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060071E1 RID: 29153 RVA: 0x0023D0D0 File Offset: 0x0023B2D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060071E2 RID: 29154 RVA: 0x0023D0E0 File Offset: 0x0023B2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060071E3 RID: 29155 RVA: 0x0023D0F0 File Offset: 0x0023B2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060071E4 RID: 29156 RVA: 0x0023D100 File Offset: 0x0023B300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060071E5 RID: 29157 RVA: 0x0023D110 File Offset: 0x0023B310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterSelectionEvent other)
		{
		}

		// Token: 0x060071E6 RID: 29158 RVA: 0x0023D120 File Offset: 0x0023B320
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060071E7 RID: 29159 RVA: 0x0023D130 File Offset: 0x0023B330
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060071E8 RID: 29160 RVA: 0x0023D140 File Offset: 0x0023B340
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterSelectionEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b != 0)
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
					continue;
				}
				CharacterSelectionEvent._parser = new MessageParser<CharacterSelectionEvent>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x060071E9 RID: 29161 RVA: 0x0023D20C File Offset: 0x0023B40C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H1a7faJewJIZ2SEI6XsK()
		{
			return true;
		}

		// Token: 0x060071EA RID: 29162 RVA: 0x0023D214 File Offset: 0x0023B414
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterSelectionEvent K0YwKmJeQxwNsIjH75QP()
		{
			return null;
		}

		// Token: 0x040027DA RID: 10202
		private static readonly MessageParser<CharacterSelectionEvent> _parser;

		// Token: 0x040027DB RID: 10203
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027DC RID: 10204
		public const int ErrorFieldNumber = 1;

		// Token: 0x040027DD RID: 10205
		public const int SuccessFieldNumber = 2;

		// Token: 0x040027DE RID: 10206
		private object result_;

		// Token: 0x040027DF RID: 10207
		private CharacterSelectionEvent.ResultOneofCase resultCase_;

		// Token: 0x040027E0 RID: 10208
		private static CharacterSelectionEvent UiNUVVJet1esVtBS5NJj;

		// Token: 0x0200092E RID: 2350
		public enum ResultOneofCase
		{
			// Token: 0x040027E2 RID: 10210
			None,
			// Token: 0x040027E3 RID: 10211
			Error,
			// Token: 0x040027E4 RID: 10212
			Success
		}

		// Token: 0x0200092F RID: 2351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060071EB RID: 29163 RVA: 0x002DBB48 File Offset: 0x002D9D48
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000930 RID: 2352
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Error : IMessage<CharacterSelectionEvent.Types.Error>, IMessage, IEquatable<CharacterSelectionEvent.Types.Error>, IDeepCloneable<CharacterSelectionEvent.Types.Error>, IBufferMessage
			{
				// Token: 0x1700147F RID: 5247
				// (get) Token: 0x060071EC RID: 29164 RVA: 0x00306AAC File Offset: 0x00304CAC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<CharacterSelectionEvent.Types.Error> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001480 RID: 5248
				// (get) Token: 0x060071ED RID: 29165 RVA: 0x00306ABC File Offset: 0x00304CBC
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

				// Token: 0x17001481 RID: 5249
				// (get) Token: 0x060071EE RID: 29166 RVA: 0x00306ACC File Offset: 0x00304CCC
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

				// Token: 0x060071EF RID: 29167 RVA: 0x00306ADC File Offset: 0x00304CDC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Error()
				{
				}

				// Token: 0x060071F0 RID: 29168 RVA: 0x00306AEC File Offset: 0x00304CEC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Error(CharacterSelectionEvent.Types.Error other)
				{
				}

				// Token: 0x060071F1 RID: 29169 RVA: 0x00306AFC File Offset: 0x00304CFC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacterSelectionEvent.Types.Error Clone()
				{
					return null;
				}

				// Token: 0x060071F2 RID: 29170 RVA: 0x00306B0C File Offset: 0x00304D0C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060071F3 RID: 29171 RVA: 0x00306B1C File Offset: 0x00304D1C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(CharacterSelectionEvent.Types.Error other)
				{
					return true;
				}

				// Token: 0x060071F4 RID: 29172 RVA: 0x00306B2C File Offset: 0x00304D2C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060071F5 RID: 29173 RVA: 0x00306B3C File Offset: 0x00304D3C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060071F6 RID: 29174 RVA: 0x00306B4C File Offset: 0x00304D4C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060071F7 RID: 29175 RVA: 0x00306B5C File Offset: 0x00304D5C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060071F8 RID: 29176 RVA: 0x00306B6C File Offset: 0x00304D6C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060071F9 RID: 29177 RVA: 0x00306B7C File Offset: 0x00304D7C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CharacterSelectionEvent.Types.Error other)
				{
				}

				// Token: 0x060071FA RID: 29178 RVA: 0x00306B8C File Offset: 0x00304D8C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060071FB RID: 29179 RVA: 0x00306B9C File Offset: 0x00304D9C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060071FC RID: 29180 RVA: 0x00306BAC File Offset: 0x00304DAC
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Error()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 != 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 4:
							CharacterSelectionEvent.Types.Error._parser = new MessageParser<CharacterSelectionEvent.Types.Error>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x060071FD RID: 29181 RVA: 0x00306CA4 File Offset: 0x00304EA4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool UrGeZgGMyoj9458tC9je()
				{
					return true;
				}

				// Token: 0x060071FE RID: 29182 RVA: 0x00306CAC File Offset: 0x00304EAC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static CharacterSelectionEvent.Types.Error Dftq7fGM6dflpvrZlY4f()
				{
					return null;
				}

				// Token: 0x040027E5 RID: 10213
				private static readonly MessageParser<CharacterSelectionEvent.Types.Error> _parser;

				// Token: 0x040027E6 RID: 10214
				private UnknownFieldSet _unknownFields;

				// Token: 0x040027E7 RID: 10215
				private static CharacterSelectionEvent.Types.Error huAdApGM5qrBNmjqihmC;
			}

			// Token: 0x02000932 RID: 2354
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Success : IMessage<CharacterSelectionEvent.Types.Success>, IMessage, IEquatable<CharacterSelectionEvent.Types.Success>, IDeepCloneable<CharacterSelectionEvent.Types.Success>, IBufferMessage
			{
				// Token: 0x17001482 RID: 5250
				// (get) Token: 0x06007204 RID: 29188 RVA: 0x00306CB4 File Offset: 0x00304EB4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<CharacterSelectionEvent.Types.Success> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001483 RID: 5251
				// (get) Token: 0x06007205 RID: 29189 RVA: 0x00306CC4 File Offset: 0x00304EC4
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

				// Token: 0x17001484 RID: 5252
				// (get) Token: 0x06007206 RID: 29190 RVA: 0x00306CD4 File Offset: 0x00304ED4
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

				// Token: 0x06007207 RID: 29191 RVA: 0x00306CE4 File Offset: 0x00304EE4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success()
				{
				}

				// Token: 0x06007208 RID: 29192 RVA: 0x00306CF4 File Offset: 0x00304EF4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success(CharacterSelectionEvent.Types.Success other)
				{
				}

				// Token: 0x06007209 RID: 29193 RVA: 0x00306D04 File Offset: 0x00304F04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacterSelectionEvent.Types.Success Clone()
				{
					return null;
				}

				// Token: 0x17001485 RID: 5253
				// (get) Token: 0x0600720A RID: 29194 RVA: 0x00306D14 File Offset: 0x00304F14
				// (set) Token: 0x0600720B RID: 29195 RVA: 0x00306D24 File Offset: 0x00304F24
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public Character Character
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

				// Token: 0x0600720C RID: 29196 RVA: 0x00306D34 File Offset: 0x00304F34
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600720D RID: 29197 RVA: 0x00306D44 File Offset: 0x00304F44
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(CharacterSelectionEvent.Types.Success other)
				{
					return true;
				}

				// Token: 0x0600720E RID: 29198 RVA: 0x00306D54 File Offset: 0x00304F54
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600720F RID: 29199 RVA: 0x00306D64 File Offset: 0x00304F64
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06007210 RID: 29200 RVA: 0x00306D74 File Offset: 0x00304F74
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06007211 RID: 29201 RVA: 0x00306D84 File Offset: 0x00304F84
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06007212 RID: 29202 RVA: 0x00306D94 File Offset: 0x00304F94
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06007213 RID: 29203 RVA: 0x00306DA4 File Offset: 0x00304FA4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CharacterSelectionEvent.Types.Success other)
				{
				}

				// Token: 0x06007214 RID: 29204 RVA: 0x00306DB4 File Offset: 0x00304FB4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06007215 RID: 29205 RVA: 0x00306DC4 File Offset: 0x00304FC4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06007216 RID: 29206 RVA: 0x00306DD4 File Offset: 0x00304FD4
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Success()
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
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							CharacterSelectionEvent.Types.Success._parser = new MessageParser<CharacterSelectionEvent.Types.Success>(() => null);
							num2 = 4;
							continue;
						case 4:
							return;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 3;
					}
				}

				// Token: 0x06007217 RID: 29207 RVA: 0x00306EA0 File Offset: 0x003050A0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool xQUgT1GMWIgxExcNC35O()
				{
					return true;
				}

				// Token: 0x06007218 RID: 29208 RVA: 0x00306EA8 File Offset: 0x003050A8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static CharacterSelectionEvent.Types.Success pNR7DbGMhg0IZtIuQQEm()
				{
					return null;
				}

				// Token: 0x040027EA RID: 10218
				private static readonly MessageParser<CharacterSelectionEvent.Types.Success> _parser;

				// Token: 0x040027EB RID: 10219
				private UnknownFieldSet _unknownFields;

				// Token: 0x040027EC RID: 10220
				public const int CharacterFieldNumber = 1;

				// Token: 0x040027ED RID: 10221
				private Character character_;

				// Token: 0x040027EE RID: 10222
				internal static CharacterSelectionEvent.Types.Success U1AfHoGMLaPFuphVSW5S;
			}
		}
	}
}
