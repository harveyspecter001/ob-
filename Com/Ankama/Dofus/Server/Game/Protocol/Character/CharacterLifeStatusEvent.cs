using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character
{
	// Token: 0x020008F9 RID: 2297
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterLifeStatusEvent : IMessage<CharacterLifeStatusEvent>, IMessage, IEquatable<CharacterLifeStatusEvent>, IDeepCloneable<CharacterLifeStatusEvent>, IBufferMessage
	{
		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06006FBA RID: 28602 RVA: 0x0023907C File Offset: 0x0023727C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterLifeStatusEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06006FBB RID: 28603 RVA: 0x0023908C File Offset: 0x0023728C
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

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x06006FBC RID: 28604 RVA: 0x0023909C File Offset: 0x0023729C
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

		// Token: 0x06006FBD RID: 28605 RVA: 0x002390AC File Offset: 0x002372AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterLifeStatusEvent()
		{
		}

		// Token: 0x06006FBE RID: 28606 RVA: 0x002390BC File Offset: 0x002372BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterLifeStatusEvent(CharacterLifeStatusEvent other)
		{
		}

		// Token: 0x06006FBF RID: 28607 RVA: 0x002390CC File Offset: 0x002372CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterLifeStatusEvent Clone()
		{
			return null;
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x06006FC0 RID: 28608 RVA: 0x002390DC File Offset: 0x002372DC
		// (set) Token: 0x06006FC1 RID: 28609 RVA: 0x002390F0 File Offset: 0x002372F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterLifeStatusEvent.Types.LifeStatus State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CharacterLifeStatusEvent.Types.LifeStatus)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x06006FC2 RID: 28610 RVA: 0x00239100 File Offset: 0x00237300
		// (set) Token: 0x06006FC3 RID: 28611 RVA: 0x00239110 File Offset: 0x00237310
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PhoenixMapId
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

		// Token: 0x06006FC4 RID: 28612 RVA: 0x00239120 File Offset: 0x00237320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006FC5 RID: 28613 RVA: 0x00239130 File Offset: 0x00237330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterLifeStatusEvent other)
		{
			return true;
		}

		// Token: 0x06006FC6 RID: 28614 RVA: 0x00239140 File Offset: 0x00237340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006FC7 RID: 28615 RVA: 0x00239150 File Offset: 0x00237350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006FC8 RID: 28616 RVA: 0x00239160 File Offset: 0x00237360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006FC9 RID: 28617 RVA: 0x00239170 File Offset: 0x00237370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006FCA RID: 28618 RVA: 0x00239180 File Offset: 0x00237380
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006FCB RID: 28619 RVA: 0x00239190 File Offset: 0x00237390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterLifeStatusEvent other)
		{
		}

		// Token: 0x06006FCC RID: 28620 RVA: 0x002391A0 File Offset: 0x002373A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006FCD RID: 28621 RVA: 0x002391B0 File Offset: 0x002373B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006FCE RID: 28622 RVA: 0x002391C0 File Offset: 0x002373C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterLifeStatusEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						goto IL_35;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						continue;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					CharacterLifeStatusEvent._parser = new MessageParser<CharacterLifeStatusEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 != 0)
					{
						num2 = 0;
					}
				}
				IL_35:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x06006FCF RID: 28623 RVA: 0x00239290 File Offset: 0x00237490
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M6MM38JB0Ftsr5GWf7rb()
		{
			return true;
		}

		// Token: 0x06006FD0 RID: 28624 RVA: 0x00239298 File Offset: 0x00237498
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterLifeStatusEvent rYJypeJBC6eeCHaVKp95()
		{
			return null;
		}

		// Token: 0x0400271D RID: 10013
		private static readonly MessageParser<CharacterLifeStatusEvent> _parser;

		// Token: 0x0400271E RID: 10014
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400271F RID: 10015
		public const int StateFieldNumber = 1;

		// Token: 0x04002720 RID: 10016
		private CharacterLifeStatusEvent.Types.LifeStatus state_;

		// Token: 0x04002721 RID: 10017
		public const int PhoenixMapIdFieldNumber = 2;

		// Token: 0x04002722 RID: 10018
		private long phoenixMapId_;

		// Token: 0x04002723 RID: 10019
		internal static CharacterLifeStatusEvent fScgHoJBVfRT14tFuKlP;

		// Token: 0x020008FA RID: 2298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06006FD1 RID: 28625 RVA: 0x002DA764 File Offset: 0x002D8964
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020008FB RID: 2299
			public enum LifeStatus
			{
				// Token: 0x04002725 RID: 10021
				[OriginalName("ALIVE_AND_KICKING")]
				AliveAndKicking,
				// Token: 0x04002726 RID: 10022
				[OriginalName("TOMBSTONE")]
				Tombstone,
				// Token: 0x04002727 RID: 10023
				[OriginalName("PHANTOM")]
				Phantom
			}
		}
	}
}
