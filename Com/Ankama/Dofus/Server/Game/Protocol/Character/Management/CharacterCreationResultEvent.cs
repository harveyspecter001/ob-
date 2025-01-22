using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x02000925 RID: 2341
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterCreationResultEvent : IMessage<CharacterCreationResultEvent>, IMessage, IEquatable<CharacterCreationResultEvent>, IDeepCloneable<CharacterCreationResultEvent>, IBufferMessage
	{
		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x0600719A RID: 29082 RVA: 0x0023CBB8 File Offset: 0x0023ADB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterCreationResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x0600719B RID: 29083 RVA: 0x0023CBC8 File Offset: 0x0023ADC8
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

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x0600719C RID: 29084 RVA: 0x0023CBD8 File Offset: 0x0023ADD8
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

		// Token: 0x0600719D RID: 29085 RVA: 0x0023CBE8 File Offset: 0x0023ADE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCreationResultEvent()
		{
		}

		// Token: 0x0600719E RID: 29086 RVA: 0x0023CBF8 File Offset: 0x0023ADF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCreationResultEvent(CharacterCreationResultEvent other)
		{
		}

		// Token: 0x0600719F RID: 29087 RVA: 0x0023CC08 File Offset: 0x0023AE08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCreationResultEvent Clone()
		{
			return null;
		}

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x060071A0 RID: 29088 RVA: 0x0023CC18 File Offset: 0x0023AE18
		// (set) Token: 0x060071A1 RID: 29089 RVA: 0x0023CC2C File Offset: 0x0023AE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterCreationResultEvent.Types.CharacterCreationResult Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CharacterCreationResultEvent.Types.CharacterCreationResult)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x060071A2 RID: 29090 RVA: 0x0023CC3C File Offset: 0x0023AE3C
		// (set) Token: 0x060071A3 RID: 29091 RVA: 0x0023CC50 File Offset: 0x0023AE50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public NameCompliance Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (NameCompliance)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060071A4 RID: 29092 RVA: 0x0023CC60 File Offset: 0x0023AE60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060071A5 RID: 29093 RVA: 0x0023CC70 File Offset: 0x0023AE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterCreationResultEvent other)
		{
			return true;
		}

		// Token: 0x060071A6 RID: 29094 RVA: 0x0023CC80 File Offset: 0x0023AE80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060071A7 RID: 29095 RVA: 0x0023CC90 File Offset: 0x0023AE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060071A8 RID: 29096 RVA: 0x0023CCA0 File Offset: 0x0023AEA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060071A9 RID: 29097 RVA: 0x0023CCB0 File Offset: 0x0023AEB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060071AA RID: 29098 RVA: 0x0023CCC0 File Offset: 0x0023AEC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060071AB RID: 29099 RVA: 0x0023CCD0 File Offset: 0x0023AED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterCreationResultEvent other)
		{
		}

		// Token: 0x060071AC RID: 29100 RVA: 0x0023CCE0 File Offset: 0x0023AEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060071AD RID: 29101 RVA: 0x0023CCF0 File Offset: 0x0023AEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060071AE RID: 29102 RVA: 0x0023CD00 File Offset: 0x0023AF00
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterCreationResultEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					CharacterCreationResultEvent._parser = new MessageParser<CharacterCreationResultEvent>(() => null);
					num2 = 3;
					break;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x060071AF RID: 29103 RVA: 0x0023CDCC File Offset: 0x0023AFCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool a8Gsf7JerchoUBuZoimS()
		{
			return true;
		}

		// Token: 0x060071B0 RID: 29104 RVA: 0x0023CDD4 File Offset: 0x0023AFD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterCreationResultEvent KBCelDJeVLn0xSsgqn6t()
		{
			return null;
		}

		// Token: 0x040027BF RID: 10175
		private static readonly MessageParser<CharacterCreationResultEvent> _parser;

		// Token: 0x040027C0 RID: 10176
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027C1 RID: 10177
		public const int ResultFieldNumber = 1;

		// Token: 0x040027C2 RID: 10178
		private CharacterCreationResultEvent.Types.CharacterCreationResult result_;

		// Token: 0x040027C3 RID: 10179
		public const int ReasonFieldNumber = 2;

		// Token: 0x040027C4 RID: 10180
		private NameCompliance reason_;

		// Token: 0x040027C5 RID: 10181
		private static CharacterCreationResultEvent JBZ7EkJeh5imDDcfUxM9;

		// Token: 0x02000926 RID: 2342
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x060071B1 RID: 29105 RVA: 0x002DB924 File Offset: 0x002D9B24
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000927 RID: 2343
			public enum CharacterCreationResult
			{
				// Token: 0x040027C7 RID: 10183
				[OriginalName("CREATE_OK")]
				CreateOk,
				// Token: 0x040027C8 RID: 10184
				[OriginalName("CREATE_ERROR_NO_REASON")]
				CreateErrorNoReason,
				// Token: 0x040027C9 RID: 10185
				[OriginalName("CREATE_ERROR_INVALID_NAME")]
				CreateErrorInvalidName,
				// Token: 0x040027CA RID: 10186
				[OriginalName("CREATE_ERROR_TOO_MANY_CHARACTERS")]
				CreateErrorTooManyCharacters,
				// Token: 0x040027CB RID: 10187
				[OriginalName("CREATE_ERROR_NOT_ALLOWED")]
				CreateErrorNotAllowed,
				// Token: 0x040027CC RID: 10188
				[OriginalName("CREATE_ERROR_NEW_PLAYER_NOT_ALLOWED")]
				CreateErrorNewPlayerNotAllowed
			}
		}
	}
}
