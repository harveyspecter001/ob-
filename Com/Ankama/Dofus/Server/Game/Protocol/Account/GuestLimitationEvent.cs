using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Account
{
	// Token: 0x02000DE8 RID: 3560
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuestLimitationEvent : IMessage<GuestLimitationEvent>, IMessage, IEquatable<GuestLimitationEvent>, IDeepCloneable<GuestLimitationEvent>, IBufferMessage
	{
		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x0600AB8D RID: 43917 RVA: 0x0029A8B0 File Offset: 0x00298AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuestLimitationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001FC8 RID: 8136
		// (get) Token: 0x0600AB8E RID: 43918 RVA: 0x0029A8C0 File Offset: 0x00298AC0
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

		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x0600AB8F RID: 43919 RVA: 0x0029A8D0 File Offset: 0x00298AD0
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

		// Token: 0x0600AB90 RID: 43920 RVA: 0x0029A8E0 File Offset: 0x00298AE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuestLimitationEvent()
		{
		}

		// Token: 0x0600AB91 RID: 43921 RVA: 0x0029A8F0 File Offset: 0x00298AF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuestLimitationEvent(GuestLimitationEvent other)
		{
		}

		// Token: 0x0600AB92 RID: 43922 RVA: 0x0029A900 File Offset: 0x00298B00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuestLimitationEvent Clone()
		{
			return null;
		}

		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x0600AB93 RID: 43923 RVA: 0x0029A910 File Offset: 0x00298B10
		// (set) Token: 0x0600AB94 RID: 43924 RVA: 0x0029A924 File Offset: 0x00298B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuestLimitationEvent.Types.GuestLimitation Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (GuestLimitationEvent.Types.GuestLimitation)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600AB95 RID: 43925 RVA: 0x0029A934 File Offset: 0x00298B34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AB96 RID: 43926 RVA: 0x0029A944 File Offset: 0x00298B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuestLimitationEvent other)
		{
			return true;
		}

		// Token: 0x0600AB97 RID: 43927 RVA: 0x0029A954 File Offset: 0x00298B54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AB98 RID: 43928 RVA: 0x0029A964 File Offset: 0x00298B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AB99 RID: 43929 RVA: 0x0029A974 File Offset: 0x00298B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AB9A RID: 43930 RVA: 0x0029A984 File Offset: 0x00298B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AB9B RID: 43931 RVA: 0x0029A994 File Offset: 0x00298B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AB9C RID: 43932 RVA: 0x0029A9A4 File Offset: 0x00298BA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuestLimitationEvent other)
		{
		}

		// Token: 0x0600AB9D RID: 43933 RVA: 0x0029A9B4 File Offset: 0x00298BB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AB9E RID: 43934 RVA: 0x0029A9C4 File Offset: 0x00298BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AB9F RID: 43935 RVA: 0x0029A9D4 File Offset: 0x00298BD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuestLimitationEvent()
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
						GuestLimitationEvent._parser = new MessageParser<GuestLimitationEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_82;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						continue;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					return;
				}
				IL_82:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x0600ABA0 RID: 43936 RVA: 0x0029AAA4 File Offset: 0x00298CA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xaKehsJU3p22iF9QIcXl()
		{
			return true;
		}

		// Token: 0x0600ABA1 RID: 43937 RVA: 0x0029AAAC File Offset: 0x00298CAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuestLimitationEvent xIkHIpJURl7TQRungC7p()
		{
			return null;
		}

		// Token: 0x04003EF4 RID: 16116
		private static readonly MessageParser<GuestLimitationEvent> _parser;

		// Token: 0x04003EF5 RID: 16117
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EF6 RID: 16118
		public const int ReasonFieldNumber = 1;

		// Token: 0x04003EF7 RID: 16119
		private GuestLimitationEvent.Types.GuestLimitation reason_;

		// Token: 0x04003EF8 RID: 16120
		private static GuestLimitationEvent X0To17JUelGW5UTAspiy;

		// Token: 0x02000DE9 RID: 3561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600ABA2 RID: 43938 RVA: 0x002F2F50 File Offset: 0x002F1150
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000DEA RID: 3562
			public enum GuestLimitation
			{
				// Token: 0x04003EFA RID: 16122
				[OriginalName("LIMITED_TO_REGISTERED")]
				LimitedToRegistered,
				// Token: 0x04003EFB RID: 16123
				[OriginalName("LIMIT_ON_JOB_XP")]
				LimitOnJobXp,
				// Token: 0x04003EFC RID: 16124
				[OriginalName("LIMIT_ON_JOB_USE")]
				LimitOnJobUse,
				// Token: 0x04003EFD RID: 16125
				[OriginalName("LIMIT_ON_MAP")]
				LimitOnMap,
				// Token: 0x04003EFE RID: 16126
				[OriginalName("LIMIT_ON_ITEM")]
				LimitOnItem,
				// Token: 0x04003EFF RID: 16127
				[OriginalName("LIMIT_ON_CHAT")]
				LimitOnChat,
				// Token: 0x04003F00 RID: 16128
				[OriginalName("LIMIT_ON_GUILD")]
				LimitOnGuild
			}
		}
	}
}
