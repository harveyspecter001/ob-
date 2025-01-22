using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x02000985 RID: 2437
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachCharactersEvent : IMessage<BreachCharactersEvent>, IMessage, IEquatable<BreachCharactersEvent>, IDeepCloneable<BreachCharactersEvent>, IBufferMessage
	{
		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x060075F2 RID: 30194 RVA: 0x002438B4 File Offset: 0x00241AB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BreachCharactersEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x060075F3 RID: 30195 RVA: 0x002438C4 File Offset: 0x00241AC4
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

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x060075F4 RID: 30196 RVA: 0x002438D4 File Offset: 0x00241AD4
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

		// Token: 0x060075F5 RID: 30197 RVA: 0x002438E4 File Offset: 0x00241AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachCharactersEvent()
		{
		}

		// Token: 0x060075F6 RID: 30198 RVA: 0x002438F4 File Offset: 0x00241AF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachCharactersEvent(BreachCharactersEvent other)
		{
		}

		// Token: 0x060075F7 RID: 30199 RVA: 0x00243904 File Offset: 0x00241B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachCharactersEvent Clone()
		{
			return null;
		}

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x060075F8 RID: 30200 RVA: 0x00243914 File Offset: 0x00241B14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<long> Players
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060075F9 RID: 30201 RVA: 0x00243924 File Offset: 0x00241B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060075FA RID: 30202 RVA: 0x00243934 File Offset: 0x00241B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachCharactersEvent other)
		{
			return true;
		}

		// Token: 0x060075FB RID: 30203 RVA: 0x00243944 File Offset: 0x00241B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060075FC RID: 30204 RVA: 0x00243954 File Offset: 0x00241B54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060075FD RID: 30205 RVA: 0x00243964 File Offset: 0x00241B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060075FE RID: 30206 RVA: 0x00243974 File Offset: 0x00241B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060075FF RID: 30207 RVA: 0x00243984 File Offset: 0x00241B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007600 RID: 30208 RVA: 0x00243994 File Offset: 0x00241B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachCharactersEvent other)
		{
		}

		// Token: 0x06007601 RID: 30209 RVA: 0x002439A4 File Offset: 0x00241BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007602 RID: 30210 RVA: 0x002439B4 File Offset: 0x00241BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007603 RID: 30211 RVA: 0x002439C4 File Offset: 0x00241BC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachCharactersEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 2:
					BreachCharactersEvent._parser = new MessageParser<BreachCharactersEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				}
				BreachCharactersEvent._repeated_players_codec = VvZHhZNDXJ0wdfV8NAG.XVInXhlssT(10U, VvZHhZNDXJ0wdfV8NAG.zpwNtgb0bl);
				num2 = 3;
			}
		}

		// Token: 0x06007604 RID: 30212 RVA: 0x00243ADC File Offset: 0x00241CDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VEfMPqJR0IZbDII3gHWi()
		{
			return true;
		}

		// Token: 0x06007605 RID: 30213 RVA: 0x00243AE4 File Offset: 0x00241CE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachCharactersEvent U80CHvJRCDXYP2A72nAB()
		{
			return null;
		}

		// Token: 0x04002911 RID: 10513
		private static readonly MessageParser<BreachCharactersEvent> _parser;

		// Token: 0x04002912 RID: 10514
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002913 RID: 10515
		public const int PlayersFieldNumber = 1;

		// Token: 0x04002914 RID: 10516
		private static readonly FieldCodec<long> _repeated_players_codec;

		// Token: 0x04002915 RID: 10517
		private readonly RepeatedField<long> players_;

		// Token: 0x04002916 RID: 10518
		private static BreachCharactersEvent yH0KWSJRVBmedLNXTXJC;
	}
}
