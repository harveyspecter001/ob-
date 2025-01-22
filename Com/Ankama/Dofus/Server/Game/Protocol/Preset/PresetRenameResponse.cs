using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x0200025B RID: 603
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetRenameResponse : IMessage<PresetRenameResponse>, IMessage, IEquatable<PresetRenameResponse>, IDeepCloneable<PresetRenameResponse>, IBufferMessage
	{
		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x001B191C File Offset: 0x001AFB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PresetRenameResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x001B192C File Offset: 0x001AFB2C
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

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x001B193C File Offset: 0x001AFB3C
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

		// Token: 0x06001C19 RID: 7193 RVA: 0x001B194C File Offset: 0x001AFB4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetRenameResponse()
		{
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x001B195C File Offset: 0x001AFB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetRenameResponse(PresetRenameResponse other)
		{
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x001B196C File Offset: 0x001AFB6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetRenameResponse Clone()
		{
			return null;
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x001B197C File Offset: 0x001AFB7C
		// (set) Token: 0x06001C1D RID: 7197 RVA: 0x001B1990 File Offset: 0x001AFB90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PresetRenameResponse.Types.Result Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PresetRenameResponse.Types.Result)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x001B19A0 File Offset: 0x001AFBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x001B19B0 File Offset: 0x001AFBB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetRenameResponse other)
		{
			return true;
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x001B19C0 File Offset: 0x001AFBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x001B19D0 File Offset: 0x001AFBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x001B19E0 File Offset: 0x001AFBE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x001B19F0 File Offset: 0x001AFBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x001B1A00 File Offset: 0x001AFC00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x001B1A10 File Offset: 0x001AFC10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetRenameResponse other)
		{
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x001B1A20 File Offset: 0x001AFC20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x001B1A30 File Offset: 0x001AFC30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x001B1A40 File Offset: 0x001AFC40
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetRenameResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 != 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return;
				case 4:
					PresetRenameResponse._parser = new MessageParser<PresetRenameResponse>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x001B1B38 File Offset: 0x001AFD38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TrNY4sO5jCMbv7ANo5BA()
		{
			return true;
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x001B1B40 File Offset: 0x001AFD40
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetRenameResponse KSf06SO5K66G9L6pAAIA()
		{
			return null;
		}

		// Token: 0x040009FA RID: 2554
		private static readonly MessageParser<PresetRenameResponse> _parser;

		// Token: 0x040009FB RID: 2555
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009FC RID: 2556
		public const int ResultFieldNumber = 1;

		// Token: 0x040009FD RID: 2557
		private PresetRenameResponse.Types.Result result_;

		// Token: 0x040009FE RID: 2558
		internal static PresetRenameResponse W76Qy2O54OccbYIUPJiv;

		// Token: 0x0200025C RID: 604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06001C2B RID: 7211 RVA: 0x002B253C File Offset: 0x002B073C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200025D RID: 605
			public enum Result
			{
				// Token: 0x04000A00 RID: 2560
				[OriginalName("SUCCESS")]
				Success,
				// Token: 0x04000A01 RID: 2561
				[OriginalName("PRESET_NOT_FOUND")]
				PresetNotFound,
				// Token: 0x04000A02 RID: 2562
				[OriginalName("ERROR_NAME_SIZE")]
				ErrorNameSize,
				// Token: 0x04000A03 RID: 2563
				[OriginalName("UNKNOWN_ERROR")]
				UnknownError,
				// Token: 0x04000A04 RID: 2564
				[OriginalName("FEATURE_DISABLED")]
				FeatureDisabled
			}
		}
	}
}
