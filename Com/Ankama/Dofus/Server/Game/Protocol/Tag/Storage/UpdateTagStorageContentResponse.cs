using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage
{
	// Token: 0x020000F4 RID: 244
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateTagStorageContentResponse : IMessage<UpdateTagStorageContentResponse>, IMessage, IEquatable<UpdateTagStorageContentResponse>, IDeepCloneable<UpdateTagStorageContentResponse>, IBufferMessage
	{
		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x00195030 File Offset: 0x00193230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateTagStorageContentResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x00195040 File Offset: 0x00193240
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

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x00195050 File Offset: 0x00193250
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

		// Token: 0x06000B11 RID: 2833 RVA: 0x00195060 File Offset: 0x00193260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UpdateTagStorageContentResponse()
		{
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00195070 File Offset: 0x00193270
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UpdateTagStorageContentResponse(UpdateTagStorageContentResponse other)
		{
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00195080 File Offset: 0x00193280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UpdateTagStorageContentResponse Clone()
		{
			return null;
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x00195090 File Offset: 0x00193290
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x001950A0 File Offset: 0x001932A0
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

		// Token: 0x06000B16 RID: 2838 RVA: 0x001950B0 File Offset: 0x001932B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x001950C0 File Offset: 0x001932C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(UpdateTagStorageContentResponse other)
		{
			return true;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x001950D0 File Offset: 0x001932D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x001950E0 File Offset: 0x001932E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x001950F0 File Offset: 0x001932F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00195100 File Offset: 0x00193300
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00195110 File Offset: 0x00193310
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00195120 File Offset: 0x00193320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(UpdateTagStorageContentResponse other)
		{
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00195130 File Offset: 0x00193330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00195140 File Offset: 0x00193340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00195150 File Offset: 0x00193350
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UpdateTagStorageContentResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UpdateTagStorageContentResponse._parser = new MessageParser<UpdateTagStorageContentResponse>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00195234 File Offset: 0x00193434
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yiM4UmOlIlhqpp56UrDu()
		{
			return true;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0019523C File Offset: 0x0019343C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static UpdateTagStorageContentResponse lqvPImOlkmDqJAgvhV5A()
		{
			return null;
		}

		// Token: 0x0400040A RID: 1034
		private static readonly MessageParser<UpdateTagStorageContentResponse> _parser;

		// Token: 0x0400040B RID: 1035
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400040C RID: 1036
		public const int TagStorageUuidFieldNumber = 1;

		// Token: 0x0400040D RID: 1037
		private string tagStorageUuid_;

		// Token: 0x0400040E RID: 1038
		internal static UpdateTagStorageContentResponse gc8ZrFOlKsCdRccTGPIc;
	}
}
