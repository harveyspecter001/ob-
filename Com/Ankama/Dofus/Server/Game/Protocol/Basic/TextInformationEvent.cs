using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic
{
	// Token: 0x02000BCC RID: 3020
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TextInformationEvent : IMessage<TextInformationEvent>, IMessage, IEquatable<TextInformationEvent>, IDeepCloneable<TextInformationEvent>, IBufferMessage
	{
		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x0600915F RID: 37215 RVA: 0x0026F9B4 File Offset: 0x0026DBB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TextInformationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x06009160 RID: 37216 RVA: 0x0026F9C4 File Offset: 0x0026DBC4
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

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x06009161 RID: 37217 RVA: 0x0026F9D4 File Offset: 0x0026DBD4
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

		// Token: 0x06009162 RID: 37218 RVA: 0x0026F9E4 File Offset: 0x0026DBE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TextInformationEvent()
		{
		}

		// Token: 0x06009163 RID: 37219 RVA: 0x0026F9F4 File Offset: 0x0026DBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TextInformationEvent(TextInformationEvent other)
		{
		}

		// Token: 0x06009164 RID: 37220 RVA: 0x0026FA04 File Offset: 0x0026DC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TextInformationEvent Clone()
		{
			return null;
		}

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x06009165 RID: 37221 RVA: 0x0026FA14 File Offset: 0x0026DC14
		// (set) Token: 0x06009166 RID: 37222 RVA: 0x0026FA28 File Offset: 0x0026DC28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public TextInformationEvent.Types.TextInformationType MessageType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TextInformationEvent.Types.TextInformationType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x06009167 RID: 37223 RVA: 0x0026FA38 File Offset: 0x0026DC38
		// (set) Token: 0x06009168 RID: 37224 RVA: 0x0026FA48 File Offset: 0x0026DC48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MessageId
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

		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x06009169 RID: 37225 RVA: 0x0026FA58 File Offset: 0x0026DC58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<string> Parameters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600916A RID: 37226 RVA: 0x0026FA68 File Offset: 0x0026DC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600916B RID: 37227 RVA: 0x0026FA78 File Offset: 0x0026DC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TextInformationEvent other)
		{
			return true;
		}

		// Token: 0x0600916C RID: 37228 RVA: 0x0026FA88 File Offset: 0x0026DC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600916D RID: 37229 RVA: 0x0026FA98 File Offset: 0x0026DC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600916E RID: 37230 RVA: 0x0026FAA8 File Offset: 0x0026DCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600916F RID: 37231 RVA: 0x0026FAB8 File Offset: 0x0026DCB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009170 RID: 37232 RVA: 0x0026FAC8 File Offset: 0x0026DCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009171 RID: 37233 RVA: 0x0026FAD8 File Offset: 0x0026DCD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TextInformationEvent other)
		{
		}

		// Token: 0x06009172 RID: 37234 RVA: 0x0026FAE8 File Offset: 0x0026DCE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009173 RID: 37235 RVA: 0x0026FAF8 File Offset: 0x0026DCF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009174 RID: 37236 RVA: 0x0026FB08 File Offset: 0x0026DD08
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TextInformationEvent()
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
						TextInformationEvent._repeated_parameters_codec = UhvKwdMSigIudSGM6ge.XVInXhlssT(26U, UhvKwdMSigIudSGM6ge.BvYMM58cmD);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 != 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_F5;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 5:
						return;
					}
					TextInformationEvent._parser = new MessageParser<TextInformationEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 != 0)
					{
						num2 = 1;
					}
				}
				IL_F5:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 2;
			}
		}

		// Token: 0x06009175 RID: 37237 RVA: 0x0026FC24 File Offset: 0x0026DE24
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool W3B2PEJ2pAiUXIeLDSQE()
		{
			return true;
		}

		// Token: 0x06009176 RID: 37238 RVA: 0x0026FC2C File Offset: 0x0026DE2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TextInformationEvent wEokjuJ2HeWYiD06iH5y()
		{
			return null;
		}

		// Token: 0x04003612 RID: 13842
		private static readonly MessageParser<TextInformationEvent> _parser;

		// Token: 0x04003613 RID: 13843
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003614 RID: 13844
		public const int MessageTypeFieldNumber = 1;

		// Token: 0x04003615 RID: 13845
		private TextInformationEvent.Types.TextInformationType messageType_;

		// Token: 0x04003616 RID: 13846
		public const int MessageIdFieldNumber = 2;

		// Token: 0x04003617 RID: 13847
		private int messageId_;

		// Token: 0x04003618 RID: 13848
		public const int ParametersFieldNumber = 3;

		// Token: 0x04003619 RID: 13849
		private static readonly FieldCodec<string> _repeated_parameters_codec;

		// Token: 0x0400361A RID: 13850
		private readonly RepeatedField<string> parameters_;

		// Token: 0x0400361B RID: 13851
		private static TextInformationEvent mToVfPJ2TRCsQCZmXr3B;

		// Token: 0x02000BCD RID: 3021
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06009177 RID: 37239 RVA: 0x002E6088 File Offset: 0x002E4288
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000BCE RID: 3022
			public enum TextInformationType
			{
				// Token: 0x0400361D RID: 13853
				[OriginalName("TEXT_INFORMATION_MESSAGE")]
				TextInformationMessage,
				// Token: 0x0400361E RID: 13854
				[OriginalName("TEXT_INFORMATION_ERROR")]
				TextInformationError,
				// Token: 0x0400361F RID: 13855
				[OriginalName("TEXT_INFORMATION_PVP")]
				TextInformationPvp,
				// Token: 0x04003620 RID: 13856
				[OriginalName("TEXT_INFORMATION_FIGHT_LOG")]
				TextInformationFightLog,
				// Token: 0x04003621 RID: 13857
				[OriginalName("TEXT_INFORMATION_POPUP")]
				TextInformationPopup,
				// Token: 0x04003622 RID: 13858
				[OriginalName("TEXT_LIVING_OBJECT")]
				TextLivingObject,
				// Token: 0x04003623 RID: 13859
				[OriginalName("TEXT_ENTITY_TALK")]
				TextEntityTalk,
				// Token: 0x04003624 RID: 13860
				[OriginalName("TEXT_INFORMATION_FIGHT")]
				TextInformationFight,
				// Token: 0x04003625 RID: 13861
				[OriginalName("TEXT_INFORMATION_EVENT")]
				TextInformationEvent
			}
		}
	}
}
