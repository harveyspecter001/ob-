using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x0200036F RID: 879
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountHarnessColorsUpdateRequest : IMessage<MountHarnessColorsUpdateRequest>, IMessage, IEquatable<MountHarnessColorsUpdateRequest>, IDeepCloneable<MountHarnessColorsUpdateRequest>, IBufferMessage
	{
		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x0600293D RID: 10557 RVA: 0x001C77D4 File Offset: 0x001C59D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MountHarnessColorsUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x0600293E RID: 10558 RVA: 0x001C77E4 File Offset: 0x001C59E4
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

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x0600293F RID: 10559 RVA: 0x001C77F4 File Offset: 0x001C59F4
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

		// Token: 0x06002940 RID: 10560 RVA: 0x001C7804 File Offset: 0x001C5A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountHarnessColorsUpdateRequest()
		{
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x001C7814 File Offset: 0x001C5A14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountHarnessColorsUpdateRequest(MountHarnessColorsUpdateRequest other)
		{
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x001C7824 File Offset: 0x001C5A24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountHarnessColorsUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x001C7834 File Offset: 0x001C5A34
		// (set) Token: 0x06002944 RID: 10564 RVA: 0x001C7844 File Offset: 0x001C5A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UseHarnessColors
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

		// Token: 0x06002945 RID: 10565 RVA: 0x001C7854 File Offset: 0x001C5A54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x001C7864 File Offset: 0x001C5A64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountHarnessColorsUpdateRequest other)
		{
			return true;
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x001C7874 File Offset: 0x001C5A74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x001C7884 File Offset: 0x001C5A84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x001C7894 File Offset: 0x001C5A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x001C78A4 File Offset: 0x001C5AA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x001C78B4 File Offset: 0x001C5AB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x001C78C4 File Offset: 0x001C5AC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountHarnessColorsUpdateRequest other)
		{
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x001C78D4 File Offset: 0x001C5AD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x001C78E4 File Offset: 0x001C5AE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x001C78F4 File Offset: 0x001C5AF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountHarnessColorsUpdateRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					MountHarnessColorsUpdateRequest._parser = new MessageParser<MountHarnessColorsUpdateRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x001C79C0 File Offset: 0x001C5BC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool j4kQ4xOrARsIja2jdG7E()
		{
			return true;
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x001C79C8 File Offset: 0x001C5BC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountHarnessColorsUpdateRequest LrAVGLOrBegILfiBaLlZ()
		{
			return null;
		}

		// Token: 0x04000E9E RID: 3742
		private static readonly MessageParser<MountHarnessColorsUpdateRequest> _parser;

		// Token: 0x04000E9F RID: 3743
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EA0 RID: 3744
		public const int UseHarnessColorsFieldNumber = 1;

		// Token: 0x04000EA1 RID: 3745
		private bool useHarnessColors_;

		// Token: 0x04000EA2 RID: 3746
		private static MountHarnessColorsUpdateRequest xgHd0tOrmOVccZCoif4s;
	}
}
