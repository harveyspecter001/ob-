using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000224 RID: 548
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetSaveResponse : IMessage<PresetSaveResponse>, IMessage, IEquatable<PresetSaveResponse>, IDeepCloneable<PresetSaveResponse>, IBufferMessage
	{
		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x001AF57C File Offset: 0x001AD77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PresetSaveResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001992 RID: 6546 RVA: 0x001AF58C File Offset: 0x001AD78C
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

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x001AF59C File Offset: 0x001AD79C
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

		// Token: 0x06001994 RID: 6548 RVA: 0x001AF5AC File Offset: 0x001AD7AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSaveResponse()
		{
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x001AF5BC File Offset: 0x001AD7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSaveResponse(PresetSaveResponse other)
		{
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x001AF5CC File Offset: 0x001AD7CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSaveResponse Clone()
		{
			return null;
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x001AF5DC File Offset: 0x001AD7DC
		// (set) Token: 0x06001998 RID: 6552 RVA: 0x001AF5EC File Offset: 0x001AD7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuccess
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

		// Token: 0x06001999 RID: 6553 RVA: 0x001AF5FC File Offset: 0x001AD7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x001AF60C File Offset: 0x001AD80C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetSaveResponse other)
		{
			return true;
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x001AF61C File Offset: 0x001AD81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x001AF62C File Offset: 0x001AD82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x001AF63C File Offset: 0x001AD83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x001AF64C File Offset: 0x001AD84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x001AF65C File Offset: 0x001AD85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x001AF66C File Offset: 0x001AD86C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetSaveResponse other)
		{
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x001AF67C File Offset: 0x001AD87C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x001AF68C File Offset: 0x001AD88C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x001AF69C File Offset: 0x001AD89C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetSaveResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					PresetSaveResponse._parser = new MessageParser<PresetSaveResponse>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x001AF780 File Offset: 0x001AD980
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nrQmvYOaLPjRT2VHyEmh()
		{
			return true;
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x001AF788 File Offset: 0x001AD988
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetSaveResponse YQYGZyOaWiTuesWRK1Dl()
		{
			return null;
		}

		// Token: 0x0400091D RID: 2333
		private static readonly MessageParser<PresetSaveResponse> _parser;

		// Token: 0x0400091E RID: 2334
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400091F RID: 2335
		public const int IsSuccessFieldNumber = 1;

		// Token: 0x04000920 RID: 2336
		private bool isSuccess_;

		// Token: 0x04000921 RID: 2337
		internal static PresetSaveResponse Jdm7CBOa6A9rEWFtFsYN;
	}
}
