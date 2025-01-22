using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002FE RID: 766
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyNameUpdateEvent : IMessage<PartyNameUpdateEvent>, IMessage, IEquatable<PartyNameUpdateEvent>, IDeepCloneable<PartyNameUpdateEvent>, IBufferMessage
	{
		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060023ED RID: 9197 RVA: 0x001BE520 File Offset: 0x001BC720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyNameUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x001BE530 File Offset: 0x001BC730
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

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060023EF RID: 9199 RVA: 0x001BE540 File Offset: 0x001BC740
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

		// Token: 0x060023F0 RID: 9200 RVA: 0x001BE550 File Offset: 0x001BC750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyNameUpdateEvent()
		{
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x001BE560 File Offset: 0x001BC760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyNameUpdateEvent(PartyNameUpdateEvent other)
		{
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x001BE570 File Offset: 0x001BC770
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyNameUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x001BE580 File Offset: 0x001BC780
		// (set) Token: 0x060023F4 RID: 9204 RVA: 0x001BE590 File Offset: 0x001BC790
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PartyId
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

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x001BE5A0 File Offset: 0x001BC7A0
		// (set) Token: 0x060023F6 RID: 9206 RVA: 0x001BE5B0 File Offset: 0x001BC7B0
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

		// Token: 0x060023F7 RID: 9207 RVA: 0x001BE5C0 File Offset: 0x001BC7C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x001BE5D0 File Offset: 0x001BC7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyNameUpdateEvent other)
		{
			return true;
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x001BE5E0 File Offset: 0x001BC7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x001BE5F0 File Offset: 0x001BC7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x001BE600 File Offset: 0x001BC800
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x001BE610 File Offset: 0x001BC810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x001BE620 File Offset: 0x001BC820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x001BE630 File Offset: 0x001BC830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyNameUpdateEvent other)
		{
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x001BE640 File Offset: 0x001BC840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x001BE650 File Offset: 0x001BC850
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x001BE660 File Offset: 0x001BC860
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyNameUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				PartyNameUpdateEvent._parser = new MessageParser<PartyNameUpdateEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x001BE744 File Offset: 0x001BC944
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UoYCY5OLpZJgsnXHnH37()
		{
			return true;
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x001BE74C File Offset: 0x001BC94C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyNameUpdateEvent fNXjWtOLHjcvd6efplGW()
		{
			return null;
		}

		// Token: 0x04000CBD RID: 3261
		private static readonly MessageParser<PartyNameUpdateEvent> _parser;

		// Token: 0x04000CBE RID: 3262
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CBF RID: 3263
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000CC0 RID: 3264
		private int partyId_;

		// Token: 0x04000CC1 RID: 3265
		public const int NameFieldNumber = 2;

		// Token: 0x04000CC2 RID: 3266
		private string name_;

		// Token: 0x04000CC3 RID: 3267
		internal static PartyNameUpdateEvent XpT3owOLTOxVYl4wGpgO;
	}
}
