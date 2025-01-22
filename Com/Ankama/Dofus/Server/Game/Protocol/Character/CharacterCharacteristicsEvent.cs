using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character
{
	// Token: 0x020008EF RID: 2287
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterCharacteristicsEvent : IMessage<CharacterCharacteristicsEvent>, IMessage, IEquatable<CharacterCharacteristicsEvent>, IDeepCloneable<CharacterCharacteristicsEvent>, IBufferMessage
	{
		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x06006F2E RID: 28462 RVA: 0x002385B0 File Offset: 0x002367B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterCharacteristicsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x06006F2F RID: 28463 RVA: 0x002385C0 File Offset: 0x002367C0
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

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x06006F30 RID: 28464 RVA: 0x002385D0 File Offset: 0x002367D0
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

		// Token: 0x06006F31 RID: 28465 RVA: 0x002385E0 File Offset: 0x002367E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristicsEvent()
		{
		}

		// Token: 0x06006F32 RID: 28466 RVA: 0x002385F0 File Offset: 0x002367F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristicsEvent(CharacterCharacteristicsEvent other)
		{
		}

		// Token: 0x06006F33 RID: 28467 RVA: 0x00238600 File Offset: 0x00236800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristicsEvent Clone()
		{
			return null;
		}

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x06006F34 RID: 28468 RVA: 0x00238610 File Offset: 0x00236810
		// (set) Token: 0x06006F35 RID: 28469 RVA: 0x00238620 File Offset: 0x00236820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterCharacteristics Stats
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

		// Token: 0x06006F36 RID: 28470 RVA: 0x00238630 File Offset: 0x00236830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006F37 RID: 28471 RVA: 0x00238640 File Offset: 0x00236840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterCharacteristicsEvent other)
		{
			return true;
		}

		// Token: 0x06006F38 RID: 28472 RVA: 0x00238650 File Offset: 0x00236850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006F39 RID: 28473 RVA: 0x00238660 File Offset: 0x00236860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006F3A RID: 28474 RVA: 0x00238670 File Offset: 0x00236870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006F3B RID: 28475 RVA: 0x00238680 File Offset: 0x00236880
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006F3C RID: 28476 RVA: 0x00238690 File Offset: 0x00236890
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006F3D RID: 28477 RVA: 0x002386A0 File Offset: 0x002368A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterCharacteristicsEvent other)
		{
		}

		// Token: 0x06006F3E RID: 28478 RVA: 0x002386B0 File Offset: 0x002368B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006F3F RID: 28479 RVA: 0x002386C0 File Offset: 0x002368C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006F40 RID: 28480 RVA: 0x002386D0 File Offset: 0x002368D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterCharacteristicsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					CharacterCharacteristicsEvent._parser = new MessageParser<CharacterCharacteristicsEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06006F41 RID: 28481 RVA: 0x002387C8 File Offset: 0x002369C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wKeAWIJBll6Ym2ksnqTW()
		{
			return true;
		}

		// Token: 0x06006F42 RID: 28482 RVA: 0x002387D0 File Offset: 0x002369D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterCharacteristicsEvent zo4ZO7JBcbBonu3j7eiq()
		{
			return null;
		}

		// Token: 0x040026F0 RID: 9968
		private static readonly MessageParser<CharacterCharacteristicsEvent> _parser;

		// Token: 0x040026F1 RID: 9969
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026F2 RID: 9970
		public const int StatsFieldNumber = 1;

		// Token: 0x040026F3 RID: 9971
		private CharacterCharacteristics stats_;

		// Token: 0x040026F4 RID: 9972
		private static CharacterCharacteristicsEvent KGAbekJBkZfNhWh1rZ3U;
	}
}
