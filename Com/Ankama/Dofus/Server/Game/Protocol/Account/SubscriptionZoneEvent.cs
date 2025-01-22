using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Account
{
	// Token: 0x02000DF2 RID: 3570
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SubscriptionZoneEvent : IMessage<SubscriptionZoneEvent>, IMessage, IEquatable<SubscriptionZoneEvent>, IDeepCloneable<SubscriptionZoneEvent>, IBufferMessage
	{
		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x0600ABDD RID: 43997 RVA: 0x0029AEF4 File Offset: 0x002990F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<SubscriptionZoneEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x0600ABDE RID: 43998 RVA: 0x0029AF04 File Offset: 0x00299104
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

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x0600ABDF RID: 43999 RVA: 0x0029AF14 File Offset: 0x00299114
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

		// Token: 0x0600ABE0 RID: 44000 RVA: 0x0029AF24 File Offset: 0x00299124
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubscriptionZoneEvent()
		{
		}

		// Token: 0x0600ABE1 RID: 44001 RVA: 0x0029AF34 File Offset: 0x00299134
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubscriptionZoneEvent(SubscriptionZoneEvent other)
		{
		}

		// Token: 0x0600ABE2 RID: 44002 RVA: 0x0029AF44 File Offset: 0x00299144
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubscriptionZoneEvent Clone()
		{
			return null;
		}

		// Token: 0x17001FD6 RID: 8150
		// (get) Token: 0x0600ABE3 RID: 44003 RVA: 0x0029AF54 File Offset: 0x00299154
		// (set) Token: 0x0600ABE4 RID: 44004 RVA: 0x0029AF64 File Offset: 0x00299164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Effective
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600ABE5 RID: 44005 RVA: 0x0029AF74 File Offset: 0x00299174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600ABE6 RID: 44006 RVA: 0x0029AF84 File Offset: 0x00299184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SubscriptionZoneEvent other)
		{
			return true;
		}

		// Token: 0x0600ABE7 RID: 44007 RVA: 0x0029AF94 File Offset: 0x00299194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600ABE8 RID: 44008 RVA: 0x0029AFA4 File Offset: 0x002991A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600ABE9 RID: 44009 RVA: 0x0029AFB4 File Offset: 0x002991B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600ABEA RID: 44010 RVA: 0x0029AFC4 File Offset: 0x002991C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600ABEB RID: 44011 RVA: 0x0029AFD4 File Offset: 0x002991D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600ABEC RID: 44012 RVA: 0x0029AFE4 File Offset: 0x002991E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SubscriptionZoneEvent other)
		{
		}

		// Token: 0x0600ABED RID: 44013 RVA: 0x0029AFF4 File Offset: 0x002991F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600ABEE RID: 44014 RVA: 0x0029B004 File Offset: 0x00299204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600ABEF RID: 44015 RVA: 0x0029B014 File Offset: 0x00299214
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SubscriptionZoneEvent()
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
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_35;
					case 4:
						SubscriptionZoneEvent._parser = new MessageParser<SubscriptionZoneEvent>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 4;
					}
				}
				IL_35:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
			}
		}

		// Token: 0x0600ABF0 RID: 44016 RVA: 0x0029B0FC File Offset: 0x002992FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool q8kPcjJU2IfoOurHdr5U()
		{
			return true;
		}

		// Token: 0x0600ABF1 RID: 44017 RVA: 0x0029B104 File Offset: 0x00299304
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SubscriptionZoneEvent Wibgf3JUE076duqRgsyp()
		{
			return null;
		}

		// Token: 0x04003F18 RID: 16152
		private static readonly MessageParser<SubscriptionZoneEvent> _parser;

		// Token: 0x04003F19 RID: 16153
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F1A RID: 16154
		public const int EffectiveFieldNumber = 1;

		// Token: 0x04003F1B RID: 16155
		private bool effective_;

		// Token: 0x04003F1C RID: 16156
		internal static SubscriptionZoneEvent KLghXxJU9Jsh0D4uoWDH;
	}
}
