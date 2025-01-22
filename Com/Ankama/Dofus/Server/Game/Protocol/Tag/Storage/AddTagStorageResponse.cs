using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage
{
	// Token: 0x020000E2 RID: 226
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AddTagStorageResponse : IMessage<AddTagStorageResponse>, IMessage, IEquatable<AddTagStorageResponse>, IDeepCloneable<AddTagStorageResponse>, IBufferMessage
	{
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x00193CF0 File Offset: 0x00191EF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AddTagStorageResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x00193D00 File Offset: 0x00191F00
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

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00193D10 File Offset: 0x00191F10
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

		// Token: 0x06000A29 RID: 2601 RVA: 0x00193D20 File Offset: 0x00191F20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddTagStorageResponse()
		{
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00193D30 File Offset: 0x00191F30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddTagStorageResponse(AddTagStorageResponse other)
		{
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00193D40 File Offset: 0x00191F40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddTagStorageResponse Clone()
		{
			return null;
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00193D50 File Offset: 0x00191F50
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x00193D60 File Offset: 0x00191F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TagStorageUuid
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

		// Token: 0x06000A2E RID: 2606 RVA: 0x00193D70 File Offset: 0x00191F70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00193D80 File Offset: 0x00191F80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AddTagStorageResponse other)
		{
			return true;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00193D90 File Offset: 0x00191F90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00193DA0 File Offset: 0x00191FA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00193DB0 File Offset: 0x00191FB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00193DC0 File Offset: 0x00191FC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00193DD0 File Offset: 0x00191FD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00193DE0 File Offset: 0x00191FE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AddTagStorageResponse other)
		{
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00193DF0 File Offset: 0x00191FF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00193E00 File Offset: 0x00192000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00193E10 File Offset: 0x00192010
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AddTagStorageResponse()
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
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AddTagStorageResponse._parser = new MessageParser<AddTagStorageResponse>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00193EDC File Offset: 0x001920DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ttJ0omOkZVNq0XGwgyrM()
		{
			return true;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00193EE4 File Offset: 0x001920E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AddTagStorageResponse w6EOZvOkqhrqtDyXqpJK()
		{
			return null;
		}

		// Token: 0x040003C5 RID: 965
		private static readonly MessageParser<AddTagStorageResponse> _parser;

		// Token: 0x040003C6 RID: 966
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003C7 RID: 967
		public const int TagStorageUuidFieldNumber = 1;

		// Token: 0x040003C8 RID: 968
		private string tagStorageUuid_;

		// Token: 0x040003C9 RID: 969
		private static AddTagStorageResponse EQQMMdOk8ro06MK96D46;
	}
}
