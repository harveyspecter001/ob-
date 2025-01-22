using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character
{
	// Token: 0x02000905 RID: 2309
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterOnConnectionEvent : IMessage<CharacterOnConnectionEvent>, IMessage, IEquatable<CharacterOnConnectionEvent>, IDeepCloneable<CharacterOnConnectionEvent>, IBufferMessage
	{
		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06007029 RID: 28713 RVA: 0x0023992C File Offset: 0x00237B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterOnConnectionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x0600702A RID: 28714 RVA: 0x0023993C File Offset: 0x00237B3C
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

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x0600702B RID: 28715 RVA: 0x0023994C File Offset: 0x00237B4C
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

		// Token: 0x0600702C RID: 28716 RVA: 0x0023995C File Offset: 0x00237B5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterOnConnectionEvent()
		{
		}

		// Token: 0x0600702D RID: 28717 RVA: 0x0023996C File Offset: 0x00237B6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterOnConnectionEvent(CharacterOnConnectionEvent other)
		{
		}

		// Token: 0x0600702E RID: 28718 RVA: 0x0023997C File Offset: 0x00237B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterOnConnectionEvent Clone()
		{
			return null;
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x0600702F RID: 28719 RVA: 0x0023998C File Offset: 0x00237B8C
		// (set) Token: 0x06007030 RID: 28720 RVA: 0x002399A0 File Offset: 0x00237BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterOnConnectionEvent.Types.ConnectionEvent ConnectionEvent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CharacterOnConnectionEvent.Types.ConnectionEvent)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06007031 RID: 28721 RVA: 0x002399B0 File Offset: 0x00237BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007032 RID: 28722 RVA: 0x002399C0 File Offset: 0x00237BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterOnConnectionEvent other)
		{
			return true;
		}

		// Token: 0x06007033 RID: 28723 RVA: 0x002399D0 File Offset: 0x00237BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007034 RID: 28724 RVA: 0x002399E0 File Offset: 0x00237BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007035 RID: 28725 RVA: 0x002399F0 File Offset: 0x00237BF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007036 RID: 28726 RVA: 0x00239A00 File Offset: 0x00237C00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007037 RID: 28727 RVA: 0x00239A10 File Offset: 0x00237C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007038 RID: 28728 RVA: 0x00239A20 File Offset: 0x00237C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterOnConnectionEvent other)
		{
		}

		// Token: 0x06007039 RID: 28729 RVA: 0x00239A30 File Offset: 0x00237C30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600703A RID: 28730 RVA: 0x00239A40 File Offset: 0x00237C40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600703B RID: 28731 RVA: 0x00239A50 File Offset: 0x00237C50
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterOnConnectionEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					CharacterOnConnectionEvent._parser = new MessageParser<CharacterOnConnectionEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600703C RID: 28732 RVA: 0x00239B34 File Offset: 0x00237D34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tLqjyHJBi0PJd8tYmNTK()
		{
			return true;
		}

		// Token: 0x0600703D RID: 28733 RVA: 0x00239B3C File Offset: 0x00237D3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterOnConnectionEvent gRhqFcJBPTLoahvR8JTh()
		{
			return null;
		}

		// Token: 0x04002748 RID: 10056
		private static readonly MessageParser<CharacterOnConnectionEvent> _parser;

		// Token: 0x04002749 RID: 10057
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400274A RID: 10058
		public const int ConnectionEventFieldNumber = 1;

		// Token: 0x0400274B RID: 10059
		private CharacterOnConnectionEvent.Types.ConnectionEvent connectionEvent_;

		// Token: 0x0400274C RID: 10060
		private static CharacterOnConnectionEvent zmvt1VJBbSMhVoobNYQv;

		// Token: 0x02000906 RID: 2310
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0600703E RID: 28734 RVA: 0x002DABA4 File Offset: 0x002D8DA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000907 RID: 2311
			public enum ConnectionEvent
			{
				// Token: 0x0400274E RID: 10062
				[OriginalName("FIRST_ACCOUNT_CONNECTION_EVER")]
				FirstAccountConnectionEver,
				// Token: 0x0400274F RID: 10063
				[OriginalName("FIRST_ACCOUNT_CONNECTION_ON_SERVER")]
				FirstAccountConnectionOnServer,
				// Token: 0x04002750 RID: 10064
				[OriginalName("FIRST_ACCOUNT_CONNECTION_SINCE_REBOOT")]
				FirstAccountConnectionSinceReboot,
				// Token: 0x04002751 RID: 10065
				[OriginalName("FIRST_CHARACTER_CONNECTION")]
				FirstCharacterConnection,
				// Token: 0x04002752 RID: 10066
				[OriginalName("FIRST_CHARACTER_CONNECTION_SINCE_REBOOT")]
				FirstCharacterConnectionSinceReboot
			}
		}
	}
}
