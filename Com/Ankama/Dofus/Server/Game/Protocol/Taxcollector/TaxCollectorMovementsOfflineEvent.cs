using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000CD RID: 205
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorMovementsOfflineEvent : IMessage<TaxCollectorMovementsOfflineEvent>, IMessage, IEquatable<TaxCollectorMovementsOfflineEvent>, IDeepCloneable<TaxCollectorMovementsOfflineEvent>, IBufferMessage
	{
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x00191DD8 File Offset: 0x0018FFD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TaxCollectorMovementsOfflineEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x00191DE8 File Offset: 0x0018FFE8
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

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x00191DF8 File Offset: 0x0018FFF8
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

		// Token: 0x06000935 RID: 2357 RVA: 0x00191E08 File Offset: 0x00190008
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorMovementsOfflineEvent()
		{
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00191E18 File Offset: 0x00190018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorMovementsOfflineEvent(TaxCollectorMovementsOfflineEvent other)
		{
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00191E28 File Offset: 0x00190028
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorMovementsOfflineEvent Clone()
		{
			return null;
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x00191E38 File Offset: 0x00190038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TaxCollectorMovement> Movements
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00191E48 File Offset: 0x00190048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00191E58 File Offset: 0x00190058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorMovementsOfflineEvent other)
		{
			return true;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00191E68 File Offset: 0x00190068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00191E78 File Offset: 0x00190078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00191E88 File Offset: 0x00190088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00191E98 File Offset: 0x00190098
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00191EA8 File Offset: 0x001900A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00191EB8 File Offset: 0x001900B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorMovementsOfflineEvent other)
		{
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00191EC8 File Offset: 0x001900C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00191ED8 File Offset: 0x001900D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00191EE8 File Offset: 0x001900E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorMovementsOfflineEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						goto IL_EA;
					case 4:
						TaxCollectorMovementsOfflineEvent._repeated_movements_codec = FieldCodec.ForMessage<TaxCollectorMovement>(10U, vPya46Kr6PyW6Q06l5C.XVInXhlssT(vPya46Kr6PyW6Q06l5C.E78KV2bNVA));
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 5:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 != 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
					{
						num2 = 5;
					}
				}
				IL_EA:
				TaxCollectorMovementsOfflineEvent._parser = new MessageParser<TaxCollectorMovementsOfflineEvent>(() => null);
				num = 4;
			}
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00192008 File Offset: 0x00190208
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LYqBRWOkv6vE9JUCM0Cb()
		{
			return true;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00192010 File Offset: 0x00190210
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorMovementsOfflineEvent bsqBOTOkov1V4ylpyIfh()
		{
			return null;
		}

		// Token: 0x0400036B RID: 875
		private static readonly MessageParser<TaxCollectorMovementsOfflineEvent> _parser;

		// Token: 0x0400036C RID: 876
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400036D RID: 877
		public const int MovementsFieldNumber = 1;

		// Token: 0x0400036E RID: 878
		private static readonly FieldCodec<TaxCollectorMovement> _repeated_movements_codec;

		// Token: 0x0400036F RID: 879
		private readonly RepeatedField<TaxCollectorMovement> movements_;

		// Token: 0x04000370 RID: 880
		private static TaxCollectorMovementsOfflineEvent oVbas0OkU6xnwN6QgUBf;
	}
}
