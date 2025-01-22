using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x02000923 RID: 2339
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CanCharacterBeCreatedResultEvent : IMessage<CanCharacterBeCreatedResultEvent>, IMessage, IEquatable<CanCharacterBeCreatedResultEvent>, IDeepCloneable<CanCharacterBeCreatedResultEvent>, IBufferMessage
	{
		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x06007180 RID: 29056 RVA: 0x0023C9BC File Offset: 0x0023ABBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CanCharacterBeCreatedResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x06007181 RID: 29057 RVA: 0x0023C9CC File Offset: 0x0023ABCC
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

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x06007182 RID: 29058 RVA: 0x0023C9DC File Offset: 0x0023ABDC
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

		// Token: 0x06007183 RID: 29059 RVA: 0x0023C9EC File Offset: 0x0023ABEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CanCharacterBeCreatedResultEvent()
		{
		}

		// Token: 0x06007184 RID: 29060 RVA: 0x0023C9FC File Offset: 0x0023ABFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CanCharacterBeCreatedResultEvent(CanCharacterBeCreatedResultEvent other)
		{
		}

		// Token: 0x06007185 RID: 29061 RVA: 0x0023CA0C File Offset: 0x0023AC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CanCharacterBeCreatedResultEvent Clone()
		{
			return null;
		}

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x06007186 RID: 29062 RVA: 0x0023CA1C File Offset: 0x0023AC1C
		// (set) Token: 0x06007187 RID: 29063 RVA: 0x0023CA2C File Offset: 0x0023AC2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Result
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

		// Token: 0x06007188 RID: 29064 RVA: 0x0023CA3C File Offset: 0x0023AC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007189 RID: 29065 RVA: 0x0023CA4C File Offset: 0x0023AC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CanCharacterBeCreatedResultEvent other)
		{
			return true;
		}

		// Token: 0x0600718A RID: 29066 RVA: 0x0023CA5C File Offset: 0x0023AC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600718B RID: 29067 RVA: 0x0023CA6C File Offset: 0x0023AC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600718C RID: 29068 RVA: 0x0023CA7C File Offset: 0x0023AC7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600718D RID: 29069 RVA: 0x0023CA8C File Offset: 0x0023AC8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600718E RID: 29070 RVA: 0x0023CA9C File Offset: 0x0023AC9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600718F RID: 29071 RVA: 0x0023CAAC File Offset: 0x0023ACAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CanCharacterBeCreatedResultEvent other)
		{
		}

		// Token: 0x06007190 RID: 29072 RVA: 0x0023CABC File Offset: 0x0023ACBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007191 RID: 29073 RVA: 0x0023CACC File Offset: 0x0023ACCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007192 RID: 29074 RVA: 0x0023CADC File Offset: 0x0023ACDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CanCharacterBeCreatedResultEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					CanCharacterBeCreatedResultEvent._parser = new MessageParser<CanCharacterBeCreatedResultEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06007193 RID: 29075 RVA: 0x0023CBA8 File Offset: 0x0023ADA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kVIHPoJeL4dIdFwtKd6b()
		{
			return true;
		}

		// Token: 0x06007194 RID: 29076 RVA: 0x0023CBB0 File Offset: 0x0023ADB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CanCharacterBeCreatedResultEvent a9TvHTJeWytNTmBQsnqA()
		{
			return null;
		}

		// Token: 0x040027B8 RID: 10168
		private static readonly MessageParser<CanCharacterBeCreatedResultEvent> _parser;

		// Token: 0x040027B9 RID: 10169
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027BA RID: 10170
		public const int ResultFieldNumber = 1;

		// Token: 0x040027BB RID: 10171
		private bool result_;

		// Token: 0x040027BC RID: 10172
		private static CanCharacterBeCreatedResultEvent U120EWJe6Yx198xlIrUR;
	}
}
