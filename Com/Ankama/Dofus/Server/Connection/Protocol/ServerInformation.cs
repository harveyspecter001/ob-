using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E29 RID: 3625
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ServerInformation : IMessage<ServerInformation>, IMessage, IEquatable<ServerInformation>, IDeepCloneable<ServerInformation>, IBufferMessage
	{
		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x0600AE4A RID: 44618 RVA: 0x0029FEA4 File Offset: 0x0029E0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ServerInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x0600AE4B RID: 44619 RVA: 0x0029FEB4 File Offset: 0x0029E0B4
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

		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x0600AE4C RID: 44620 RVA: 0x0029FEC4 File Offset: 0x0029E0C4
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

		// Token: 0x0600AE4D RID: 44621 RVA: 0x0029FED4 File Offset: 0x0029E0D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerInformation()
		{
		}

		// Token: 0x0600AE4E RID: 44622 RVA: 0x0029FEE4 File Offset: 0x0029E0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerInformation(ServerInformation other)
		{
		}

		// Token: 0x0600AE4F RID: 44623 RVA: 0x0029FEF4 File Offset: 0x0029E0F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerInformation Clone()
		{
			return null;
		}

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x0600AE50 RID: 44624 RVA: 0x0029FF04 File Offset: 0x0029E104
		// (set) Token: 0x0600AE51 RID: 44625 RVA: 0x0029FF14 File Offset: 0x0029E114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Server Server
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

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x0600AE52 RID: 44626 RVA: 0x0029FF24 File Offset: 0x0029E124
		// (set) Token: 0x0600AE53 RID: 44627 RVA: 0x0029FF38 File Offset: 0x0029E138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerInformation.Types.Accessibility Accessibility
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ServerInformation.Types.Accessibility)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x0600AE54 RID: 44628 RVA: 0x0029FF48 File Offset: 0x0029E148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CharacterInformation> Characters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AE55 RID: 44629 RVA: 0x0029FF58 File Offset: 0x0029E158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AE56 RID: 44630 RVA: 0x0029FF68 File Offset: 0x0029E168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ServerInformation other)
		{
			return true;
		}

		// Token: 0x0600AE57 RID: 44631 RVA: 0x0029FF78 File Offset: 0x0029E178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AE58 RID: 44632 RVA: 0x0029FF88 File Offset: 0x0029E188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AE59 RID: 44633 RVA: 0x0029FF98 File Offset: 0x0029E198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AE5A RID: 44634 RVA: 0x0029FFA8 File Offset: 0x0029E1A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AE5B RID: 44635 RVA: 0x0029FFB8 File Offset: 0x0029E1B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AE5C RID: 44636 RVA: 0x0029FFC8 File Offset: 0x0029E1C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ServerInformation other)
		{
		}

		// Token: 0x0600AE5D RID: 44637 RVA: 0x0029FFD8 File Offset: 0x0029E1D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AE5E RID: 44638 RVA: 0x0029FFE8 File Offset: 0x0029E1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AE5F RID: 44639 RVA: 0x0029FFF8 File Offset: 0x0029E1F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ServerInformation()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					ServerInformation._repeated_characters_codec = FieldCodec.ForMessage<CharacterInformation>(26U, Bo0n2c3NE31HNyRtimJB.XVInXhlssT(Bo0n2c3NE31HNyRtimJB.dxE3NXZhJRm));
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 4:
					return;
				case 5:
					ServerInformation._parser = new MessageParser<ServerInformation>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x0600AE60 RID: 44640 RVA: 0x002A0100 File Offset: 0x0029E300
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NBZTOYJvnI0sfNIEL2LQ()
		{
			return true;
		}

		// Token: 0x0600AE61 RID: 44641 RVA: 0x002A0108 File Offset: 0x0029E308
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ServerInformation oxvP2xJvmXxKEFL9jrX5()
		{
			return null;
		}

		// Token: 0x04004024 RID: 16420
		private static readonly MessageParser<ServerInformation> _parser;

		// Token: 0x04004025 RID: 16421
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004026 RID: 16422
		public const int ServerFieldNumber = 1;

		// Token: 0x04004027 RID: 16423
		private Server server_;

		// Token: 0x04004028 RID: 16424
		public const int AccessibilityFieldNumber = 2;

		// Token: 0x04004029 RID: 16425
		private ServerInformation.Types.Accessibility accessibility_;

		// Token: 0x0400402A RID: 16426
		public const int CharactersFieldNumber = 3;

		// Token: 0x0400402B RID: 16427
		private static readonly FieldCodec<CharacterInformation> _repeated_characters_codec;

		// Token: 0x0400402C RID: 16428
		private readonly RepeatedField<CharacterInformation> characters_;

		// Token: 0x0400402D RID: 16429
		private static ServerInformation c4Lu49Jvf9QKACH1WOe4;

		// Token: 0x02000E2A RID: 3626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600AE62 RID: 44642 RVA: 0x002F40CC File Offset: 0x002F22CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000E2B RID: 3627
			public enum Accessibility
			{
				// Token: 0x0400402F RID: 16431
				[OriginalName("ACCESSIBLE")]
				Accessible,
				// Token: 0x04004030 RID: 16432
				[OriginalName("SUBSCRIBE_RESTRICTION")]
				SubscribeRestriction,
				// Token: 0x04004031 RID: 16433
				[OriginalName("MONO_ACCOUNT_RESTRICTION")]
				MonoAccountRestriction,
				// Token: 0x04004032 RID: 16434
				[OriginalName("UNKNOWN")]
				Unknown
			}
		}
	}
}
