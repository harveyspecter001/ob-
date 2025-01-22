using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x0200042B RID: 1067
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StorageTab : IMessage<StorageTab>, IMessage, IEquatable<StorageTab>, IDeepCloneable<StorageTab>, IBufferMessage
	{
		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x0600328B RID: 12939 RVA: 0x001D6734 File Offset: 0x001D4934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StorageTab> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x0600328C RID: 12940 RVA: 0x001D6744 File Offset: 0x001D4944
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

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x0600328D RID: 12941 RVA: 0x001D6754 File Offset: 0x001D4954
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

		// Token: 0x0600328E RID: 12942 RVA: 0x001D6764 File Offset: 0x001D4964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageTab()
		{
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x001D6774 File Offset: 0x001D4974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageTab(StorageTab other)
		{
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x001D6784 File Offset: 0x001D4984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorageTab Clone()
		{
			return null;
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06003291 RID: 12945 RVA: 0x001D6794 File Offset: 0x001D4994
		// (set) Token: 0x06003292 RID: 12946 RVA: 0x001D67A4 File Offset: 0x001D49A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
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

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06003293 RID: 12947 RVA: 0x001D67B4 File Offset: 0x001D49B4
		// (set) Token: 0x06003294 RID: 12948 RVA: 0x001D67C4 File Offset: 0x001D49C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TabNumber
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

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06003295 RID: 12949 RVA: 0x001D67D4 File Offset: 0x001D49D4
		// (set) Token: 0x06003296 RID: 12950 RVA: 0x001D67E4 File Offset: 0x001D49E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Picto
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

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06003297 RID: 12951 RVA: 0x001D67F4 File Offset: 0x001D49F4
		// (set) Token: 0x06003298 RID: 12952 RVA: 0x001D6804 File Offset: 0x001D4A04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int OpenRight
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

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06003299 RID: 12953 RVA: 0x001D6814 File Offset: 0x001D4A14
		// (set) Token: 0x0600329A RID: 12954 RVA: 0x001D6824 File Offset: 0x001D4A24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int DropRight
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

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x0600329B RID: 12955 RVA: 0x001D6834 File Offset: 0x001D4A34
		// (set) Token: 0x0600329C RID: 12956 RVA: 0x001D6844 File Offset: 0x001D4A44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int TakeRight
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

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x0600329D RID: 12957 RVA: 0x001D6854 File Offset: 0x001D4A54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> DropTypeLimit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x001D6864 File Offset: 0x001D4A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x001D6874 File Offset: 0x001D4A74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(StorageTab other)
		{
			return true;
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x001D6884 File Offset: 0x001D4A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x001D6894 File Offset: 0x001D4A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x001D68A4 File Offset: 0x001D4AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x001D68B4 File Offset: 0x001D4AB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x001D68C4 File Offset: 0x001D4AC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x001D68D4 File Offset: 0x001D4AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(StorageTab other)
		{
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x001D68E4 File Offset: 0x001D4AE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x001D68F4 File Offset: 0x001D4AF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x001D6904 File Offset: 0x001D4B04
		[MethodImpl(MethodImplOptions.NoInlining)]
		static StorageTab()
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
						goto IL_A7;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						continue;
					case 4:
						StorageTab._parser = new MessageParser<StorageTab>(() => null);
						num2 = 5;
						continue;
					case 5:
						StorageTab._repeated_dropTypeLimit_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(58U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_A7:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
			}
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x001D69F4 File Offset: 0x001D4BF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YEkRQnODnuHrhN753EFG()
		{
			return true;
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x001D69FC File Offset: 0x001D4BFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static StorageTab M2GkulODmveZGCvltVYx()
		{
			return null;
		}

		// Token: 0x040011AA RID: 4522
		private static readonly MessageParser<StorageTab> _parser;

		// Token: 0x040011AB RID: 4523
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011AC RID: 4524
		public const int NameFieldNumber = 1;

		// Token: 0x040011AD RID: 4525
		private string name_;

		// Token: 0x040011AE RID: 4526
		public const int TabNumberFieldNumber = 2;

		// Token: 0x040011AF RID: 4527
		private int tabNumber_;

		// Token: 0x040011B0 RID: 4528
		public const int PictoFieldNumber = 3;

		// Token: 0x040011B1 RID: 4529
		private int picto_;

		// Token: 0x040011B2 RID: 4530
		public const int OpenRightFieldNumber = 4;

		// Token: 0x040011B3 RID: 4531
		private int openRight_;

		// Token: 0x040011B4 RID: 4532
		public const int DropRightFieldNumber = 5;

		// Token: 0x040011B5 RID: 4533
		private int dropRight_;

		// Token: 0x040011B6 RID: 4534
		public const int TakeRightFieldNumber = 6;

		// Token: 0x040011B7 RID: 4535
		private int takeRight_;

		// Token: 0x040011B8 RID: 4536
		public const int DropTypeLimitFieldNumber = 7;

		// Token: 0x040011B9 RID: 4537
		private static readonly FieldCodec<int> _repeated_dropTypeLimit_codec;

		// Token: 0x040011BA RID: 4538
		private readonly RepeatedField<int> dropTypeLimit_;

		// Token: 0x040011BB RID: 4539
		private static StorageTab qnHD4KODf3pYMoYhjkua;
	}
}
