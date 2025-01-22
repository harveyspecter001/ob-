using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x02000945 RID: 2373
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterListErrorEvent : IMessage<CharacterListErrorEvent>, IMessage, IEquatable<CharacterListErrorEvent>, IDeepCloneable<CharacterListErrorEvent>, IBufferMessage
	{
		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x060072DD RID: 29405 RVA: 0x0023E16C File Offset: 0x0023C36C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterListErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x060072DE RID: 29406 RVA: 0x0023E17C File Offset: 0x0023C37C
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

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x060072DF RID: 29407 RVA: 0x0023E18C File Offset: 0x0023C38C
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

		// Token: 0x060072E0 RID: 29408 RVA: 0x0023E19C File Offset: 0x0023C39C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterListErrorEvent()
		{
		}

		// Token: 0x060072E1 RID: 29409 RVA: 0x0023E1AC File Offset: 0x0023C3AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterListErrorEvent(CharacterListErrorEvent other)
		{
		}

		// Token: 0x060072E2 RID: 29410 RVA: 0x0023E1BC File Offset: 0x0023C3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterListErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x060072E3 RID: 29411 RVA: 0x0023E1CC File Offset: 0x0023C3CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060072E4 RID: 29412 RVA: 0x0023E1DC File Offset: 0x0023C3DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterListErrorEvent other)
		{
			return true;
		}

		// Token: 0x060072E5 RID: 29413 RVA: 0x0023E1EC File Offset: 0x0023C3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060072E6 RID: 29414 RVA: 0x0023E1FC File Offset: 0x0023C3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060072E7 RID: 29415 RVA: 0x0023E20C File Offset: 0x0023C40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060072E8 RID: 29416 RVA: 0x0023E21C File Offset: 0x0023C41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060072E9 RID: 29417 RVA: 0x0023E22C File Offset: 0x0023C42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060072EA RID: 29418 RVA: 0x0023E23C File Offset: 0x0023C43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterListErrorEvent other)
		{
		}

		// Token: 0x060072EB RID: 29419 RVA: 0x0023E24C File Offset: 0x0023C44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060072EC RID: 29420 RVA: 0x0023E25C File Offset: 0x0023C45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060072ED RID: 29421 RVA: 0x0023E26C File Offset: 0x0023C46C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterListErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					CharacterListErrorEvent._parser = new MessageParser<CharacterListErrorEvent>(() => null);
					num2 = 4;
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x060072EE RID: 29422 RVA: 0x0023E338 File Offset: 0x0023C538
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LxAkVsJ33JJ3eA5oZnRG()
		{
			return true;
		}

		// Token: 0x060072EF RID: 29423 RVA: 0x0023E340 File Offset: 0x0023C540
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterListErrorEvent mSRF9pJ3Ru5CX1AFH48Q()
		{
			return null;
		}

		// Token: 0x04002830 RID: 10288
		private static readonly MessageParser<CharacterListErrorEvent> _parser;

		// Token: 0x04002831 RID: 10289
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002832 RID: 10290
		internal static CharacterListErrorEvent xJePEGJ3eevhuh4alcTA;
	}
}
