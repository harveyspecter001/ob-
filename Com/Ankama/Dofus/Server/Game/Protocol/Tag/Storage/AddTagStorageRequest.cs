using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage
{
	// Token: 0x020000E0 RID: 224
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AddTagStorageRequest : IMessage<AddTagStorageRequest>, IMessage, IEquatable<AddTagStorageRequest>, IDeepCloneable<AddTagStorageRequest>, IBufferMessage
	{
		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x00193ABC File Offset: 0x00191CBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AddTagStorageRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x00193ACC File Offset: 0x00191CCC
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

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00193ADC File Offset: 0x00191CDC
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

		// Token: 0x06000A0D RID: 2573 RVA: 0x00193AEC File Offset: 0x00191CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddTagStorageRequest()
		{
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00193AFC File Offset: 0x00191CFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddTagStorageRequest(AddTagStorageRequest other)
		{
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00193B0C File Offset: 0x00191D0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddTagStorageRequest Clone()
		{
			return null;
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00193B1C File Offset: 0x00191D1C
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x00193B2C File Offset: 0x00191D2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00193B3C File Offset: 0x00191D3C
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x00193B4C File Offset: 0x00191D4C
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

		// Token: 0x06000A14 RID: 2580 RVA: 0x00193B5C File Offset: 0x00191D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00193B6C File Offset: 0x00191D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AddTagStorageRequest other)
		{
			return true;
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00193B7C File Offset: 0x00191D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00193B8C File Offset: 0x00191D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00193B9C File Offset: 0x00191D9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00193BAC File Offset: 0x00191DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00193BBC File Offset: 0x00191DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00193BCC File Offset: 0x00191DCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AddTagStorageRequest other)
		{
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00193BDC File Offset: 0x00191DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00193BEC File Offset: 0x00191DEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00193BFC File Offset: 0x00191DFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AddTagStorageRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AddTagStorageRequest._parser = new MessageParser<AddTagStorageRequest>(() => null);
					num2 = 3;
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00193CE0 File Offset: 0x00191EE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xq4xftOkMN3uSWLVyDM6()
		{
			return true;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00193CE8 File Offset: 0x00191EE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AddTagStorageRequest QAGLYgOkuy9XxgI0Unlm()
		{
			return null;
		}

		// Token: 0x040003BC RID: 956
		private static readonly MessageParser<AddTagStorageRequest> _parser;

		// Token: 0x040003BD RID: 957
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003BE RID: 958
		public const int NameFieldNumber = 1;

		// Token: 0x040003BF RID: 959
		private string name_;

		// Token: 0x040003C0 RID: 960
		public const int PictoFieldNumber = 2;

		// Token: 0x040003C1 RID: 961
		private int picto_;

		// Token: 0x040003C2 RID: 962
		private static AddTagStorageRequest BKxkVkOkSO91DtvZDpyO;
	}
}
