using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B54 RID: 2900
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectItemInventory : IMessage<ObjectItemInventory>, IMessage, IEquatable<ObjectItemInventory>, IDeepCloneable<ObjectItemInventory>, IBufferMessage
	{
		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x06008AD7 RID: 35543 RVA: 0x00268A30 File Offset: 0x00266C30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ObjectItemInventory> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x06008AD8 RID: 35544 RVA: 0x00268A40 File Offset: 0x00266C40
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

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x06008AD9 RID: 35545 RVA: 0x00268A50 File Offset: 0x00266C50
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

		// Token: 0x06008ADA RID: 35546 RVA: 0x00268A60 File Offset: 0x00266C60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectItemInventory()
		{
		}

		// Token: 0x06008ADB RID: 35547 RVA: 0x00268A70 File Offset: 0x00266C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectItemInventory(ObjectItemInventory other)
		{
		}

		// Token: 0x06008ADC RID: 35548 RVA: 0x00268A80 File Offset: 0x00266C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectItemInventory Clone()
		{
			return null;
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x06008ADD RID: 35549 RVA: 0x00268A90 File Offset: 0x00266C90
		// (set) Token: 0x06008ADE RID: 35550 RVA: 0x00268AA0 File Offset: 0x00266CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Position
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

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x06008ADF RID: 35551 RVA: 0x00268AB0 File Offset: 0x00266CB0
		// (set) Token: 0x06008AE0 RID: 35552 RVA: 0x00268AC0 File Offset: 0x00266CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ObjectItem Item
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

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x06008AE1 RID: 35553 RVA: 0x00268AD0 File Offset: 0x00266CD0
		// (set) Token: 0x06008AE2 RID: 35554 RVA: 0x00268AE0 File Offset: 0x00266CE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Favorite
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

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x06008AE3 RID: 35555 RVA: 0x00268AF0 File Offset: 0x00266CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> TagStorageUuids
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06008AE4 RID: 35556 RVA: 0x00268B00 File Offset: 0x00266D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008AE5 RID: 35557 RVA: 0x00268B10 File Offset: 0x00266D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectItemInventory other)
		{
			return true;
		}

		// Token: 0x06008AE6 RID: 35558 RVA: 0x00268B20 File Offset: 0x00266D20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008AE7 RID: 35559 RVA: 0x00268B30 File Offset: 0x00266D30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008AE8 RID: 35560 RVA: 0x00268B40 File Offset: 0x00266D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008AE9 RID: 35561 RVA: 0x00268B50 File Offset: 0x00266D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008AEA RID: 35562 RVA: 0x00268B60 File Offset: 0x00266D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008AEB RID: 35563 RVA: 0x00268B70 File Offset: 0x00266D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectItemInventory other)
		{
		}

		// Token: 0x06008AEC RID: 35564 RVA: 0x00268B80 File Offset: 0x00266D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008AED RID: 35565 RVA: 0x00268B90 File Offset: 0x00266D90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008AEE RID: 35566 RVA: 0x00268BA0 File Offset: 0x00266DA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectItemInventory()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_62;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						ObjectItemInventory._repeated_tagStorageUuids_codec = UhvKwdMSigIudSGM6ge.XVInXhlssT(34U, UhvKwdMSigIudSGM6ge.BvYMM58cmD);
						num2 = 5;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						return;
					}
					ObjectItemInventory._parser = new MessageParser<ObjectItemInventory>(() => null);
					num2 = 3;
				}
				IL_62:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x06008AEF RID: 35567 RVA: 0x00268CA4 File Offset: 0x00266EA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gDdIGUJdZi25JWhnWS21()
		{
			return true;
		}

		// Token: 0x06008AF0 RID: 35568 RVA: 0x00268CAC File Offset: 0x00266EAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectItemInventory lUS5WAJdq8mGMvcD78O1()
		{
			return null;
		}

		// Token: 0x04003329 RID: 13097
		private static readonly MessageParser<ObjectItemInventory> _parser;

		// Token: 0x0400332A RID: 13098
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400332B RID: 13099
		public const int PositionFieldNumber = 1;

		// Token: 0x0400332C RID: 13100
		private int position_;

		// Token: 0x0400332D RID: 13101
		public const int ItemFieldNumber = 2;

		// Token: 0x0400332E RID: 13102
		private ObjectItem item_;

		// Token: 0x0400332F RID: 13103
		public const int FavoriteFieldNumber = 3;

		// Token: 0x04003330 RID: 13104
		private bool favorite_;

		// Token: 0x04003331 RID: 13105
		public const int TagStorageUuidsFieldNumber = 4;

		// Token: 0x04003332 RID: 13106
		private static readonly FieldCodec<string> _repeated_tagStorageUuids_codec;

		// Token: 0x04003333 RID: 13107
		private readonly RepeatedField<string> tagStorageUuids_;

		// Token: 0x04003334 RID: 13108
		internal static ObjectItemInventory rnf8kBJd8u2RVOpiQI78;
	}
}
