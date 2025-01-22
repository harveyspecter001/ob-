using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application
{
	// Token: 0x02000564 RID: 1380
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildApplicationPlayerEvent : IMessage<GuildApplicationPlayerEvent>, IMessage, IEquatable<GuildApplicationPlayerEvent>, IDeepCloneable<GuildApplicationPlayerEvent>, IBufferMessage
	{
		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06004264 RID: 16996 RVA: 0x001F1DF0 File Offset: 0x001EFFF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildApplicationPlayerEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06004265 RID: 16997 RVA: 0x001F1E00 File Offset: 0x001F0000
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

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06004266 RID: 16998 RVA: 0x001F1E10 File Offset: 0x001F0010
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

		// Token: 0x06004267 RID: 16999 RVA: 0x001F1E20 File Offset: 0x001F0020
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationPlayerEvent()
		{
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x001F1E30 File Offset: 0x001F0030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationPlayerEvent(GuildApplicationPlayerEvent other)
		{
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x001F1E40 File Offset: 0x001F0040
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationPlayerEvent Clone()
		{
			return null;
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x0600426A RID: 17002 RVA: 0x001F1E50 File Offset: 0x001F0050
		// (set) Token: 0x0600426B RID: 17003 RVA: 0x001F1E60 File Offset: 0x001F0060
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GuildApplicationPlayerEvent.Types.ApplicationInformation Application
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

		// Token: 0x0600426C RID: 17004 RVA: 0x001F1E70 File Offset: 0x001F0070
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600426D RID: 17005 RVA: 0x001F1E80 File Offset: 0x001F0080
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildApplicationPlayerEvent other)
		{
			return true;
		}

		// Token: 0x0600426E RID: 17006 RVA: 0x001F1E90 File Offset: 0x001F0090
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600426F RID: 17007 RVA: 0x001F1EA0 File Offset: 0x001F00A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x001F1EB0 File Offset: 0x001F00B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x001F1EC0 File Offset: 0x001F00C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x001F1ED0 File Offset: 0x001F00D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004273 RID: 17011 RVA: 0x001F1EE0 File Offset: 0x001F00E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildApplicationPlayerEvent other)
		{
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x001F1EF0 File Offset: 0x001F00F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x001F1F00 File Offset: 0x001F0100
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004276 RID: 17014 RVA: 0x001F1F10 File Offset: 0x001F0110
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildApplicationPlayerEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c != 0)
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
					GuildApplicationPlayerEvent._parser = new MessageParser<GuildApplicationPlayerEvent>(() => null);
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

		// Token: 0x06004277 RID: 17015 RVA: 0x001F1FF4 File Offset: 0x001F01F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xukQmEOHo1lsOZPeRscm()
		{
			return true;
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x001F1FFC File Offset: 0x001F01FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildApplicationPlayerEvent dp79XQOH1HWDum4AAOYx()
		{
			return null;
		}

		// Token: 0x040016E5 RID: 5861
		private static readonly MessageParser<GuildApplicationPlayerEvent> _parser;

		// Token: 0x040016E6 RID: 5862
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016E7 RID: 5863
		public const int ApplicationFieldNumber = 1;

		// Token: 0x040016E8 RID: 5864
		private GuildApplicationPlayerEvent.Types.ApplicationInformation application_;

		// Token: 0x040016E9 RID: 5865
		private static GuildApplicationPlayerEvent fX24nlOHveRJ6PKyHhMh;

		// Token: 0x02000565 RID: 1381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06004279 RID: 17017 RVA: 0x002C6468 File Offset: 0x002C4668
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000566 RID: 1382
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ApplicationInformation : IMessage<GuildApplicationPlayerEvent.Types.ApplicationInformation>, IMessage, IEquatable<GuildApplicationPlayerEvent.Types.ApplicationInformation>, IDeepCloneable<GuildApplicationPlayerEvent.Types.ApplicationInformation>, IBufferMessage
			{
				// Token: 0x17000BD4 RID: 3028
				// (get) Token: 0x0600427A RID: 17018 RVA: 0x002FC7D8 File Offset: 0x002FA9D8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<GuildApplicationPlayerEvent.Types.ApplicationInformation> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000BD5 RID: 3029
				// (get) Token: 0x0600427B RID: 17019 RVA: 0x002FC7E8 File Offset: 0x002FA9E8
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

				// Token: 0x17000BD6 RID: 3030
				// (get) Token: 0x0600427C RID: 17020 RVA: 0x002FC7F8 File Offset: 0x002FA9F8
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

				// Token: 0x0600427D RID: 17021 RVA: 0x002FC808 File Offset: 0x002FAA08
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ApplicationInformation()
				{
				}

				// Token: 0x0600427E RID: 17022 RVA: 0x002FC818 File Offset: 0x002FAA18
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ApplicationInformation(GuildApplicationPlayerEvent.Types.ApplicationInformation other)
				{
				}

				// Token: 0x0600427F RID: 17023 RVA: 0x002FC828 File Offset: 0x002FAA28
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GuildApplicationPlayerEvent.Types.ApplicationInformation Clone()
				{
					return null;
				}

				// Token: 0x17000BD7 RID: 3031
				// (get) Token: 0x06004280 RID: 17024 RVA: 0x002FC838 File Offset: 0x002FAA38
				// (set) Token: 0x06004281 RID: 17025 RVA: 0x002FC848 File Offset: 0x002FAA48
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public GuildInformation GuildInformation
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

				// Token: 0x17000BD8 RID: 3032
				// (get) Token: 0x06004282 RID: 17026 RVA: 0x002FC858 File Offset: 0x002FAA58
				// (set) Token: 0x06004283 RID: 17027 RVA: 0x002FC868 File Offset: 0x002FAA68
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public SocialApplicationInformation Apply
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

				// Token: 0x06004284 RID: 17028 RVA: 0x002FC878 File Offset: 0x002FAA78
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004285 RID: 17029 RVA: 0x002FC888 File Offset: 0x002FAA88
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GuildApplicationPlayerEvent.Types.ApplicationInformation other)
				{
					return true;
				}

				// Token: 0x06004286 RID: 17030 RVA: 0x002FC898 File Offset: 0x002FAA98
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004287 RID: 17031 RVA: 0x002FC8A8 File Offset: 0x002FAAA8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004288 RID: 17032 RVA: 0x002FC8B8 File Offset: 0x002FAAB8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004289 RID: 17033 RVA: 0x002FC8C8 File Offset: 0x002FAAC8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600428A RID: 17034 RVA: 0x002FC8D8 File Offset: 0x002FAAD8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600428B RID: 17035 RVA: 0x002FC8E8 File Offset: 0x002FAAE8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GuildApplicationPlayerEvent.Types.ApplicationInformation other)
				{
				}

				// Token: 0x0600428C RID: 17036 RVA: 0x002FC8F8 File Offset: 0x002FAAF8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600428D RID: 17037 RVA: 0x002FC908 File Offset: 0x002FAB08
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600428E RID: 17038 RVA: 0x002FC918 File Offset: 0x002FAB18
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ApplicationInformation()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 3:
							return;
						case 4:
							GuildApplicationPlayerEvent.Types.ApplicationInformation._parser = new MessageParser<GuildApplicationPlayerEvent.Types.ApplicationInformation>(() => null);
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
						{
							num2 = 0;
						}
					}
				}

				// Token: 0x0600428F RID: 17039 RVA: 0x002FCA10 File Offset: 0x002FAC10
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool AHFpQZGben1uT52K5K16()
				{
					return true;
				}

				// Token: 0x06004290 RID: 17040 RVA: 0x002FCA18 File Offset: 0x002FAC18
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GuildApplicationPlayerEvent.Types.ApplicationInformation U80Xp6Gb3fvfH9f9EaBA()
				{
					return null;
				}

				// Token: 0x040016EA RID: 5866
				private static readonly MessageParser<GuildApplicationPlayerEvent.Types.ApplicationInformation> _parser;

				// Token: 0x040016EB RID: 5867
				private UnknownFieldSet _unknownFields;

				// Token: 0x040016EC RID: 5868
				public const int GuildInformationFieldNumber = 1;

				// Token: 0x040016ED RID: 5869
				private GuildInformation guildInformation_;

				// Token: 0x040016EE RID: 5870
				public const int ApplyFieldNumber = 2;

				// Token: 0x040016EF RID: 5871
				private SocialApplicationInformation apply_;

				// Token: 0x040016F0 RID: 5872
				internal static GuildApplicationPlayerEvent.Types.ApplicationInformation DZPY7wGbBFeSxKQDociK;
			}
		}
	}
}
