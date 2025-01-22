using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000836 RID: 2102
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IgnoreRequest : IMessage<IgnoreRequest>, IMessage, IEquatable<IgnoreRequest>, IDeepCloneable<IgnoreRequest>, IBufferMessage
	{
		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x06006624 RID: 26148 RVA: 0x0022B560 File Offset: 0x00229760
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<IgnoreRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x06006625 RID: 26149 RVA: 0x0022B570 File Offset: 0x00229770
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

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x06006626 RID: 26150 RVA: 0x0022B580 File Offset: 0x00229780
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

		// Token: 0x06006627 RID: 26151 RVA: 0x0022B590 File Offset: 0x00229790
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IgnoreRequest()
		{
		}

		// Token: 0x06006628 RID: 26152 RVA: 0x0022B5A0 File Offset: 0x002297A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IgnoreRequest(IgnoreRequest other)
		{
		}

		// Token: 0x06006629 RID: 26153 RVA: 0x0022B5B0 File Offset: 0x002297B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IgnoreRequest Clone()
		{
			return null;
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x0600662A RID: 26154 RVA: 0x0022B5C0 File Offset: 0x002297C0
		// (set) Token: 0x0600662B RID: 26155 RVA: 0x0022B5D0 File Offset: 0x002297D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PlayerSearch PlayerSearch
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

		// Token: 0x0600662C RID: 26156 RVA: 0x0022B5E0 File Offset: 0x002297E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600662D RID: 26157 RVA: 0x0022B5F0 File Offset: 0x002297F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(IgnoreRequest other)
		{
			return true;
		}

		// Token: 0x0600662E RID: 26158 RVA: 0x0022B600 File Offset: 0x00229800
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600662F RID: 26159 RVA: 0x0022B610 File Offset: 0x00229810
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006630 RID: 26160 RVA: 0x0022B620 File Offset: 0x00229820
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006631 RID: 26161 RVA: 0x0022B630 File Offset: 0x00229830
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006632 RID: 26162 RVA: 0x0022B640 File Offset: 0x00229840
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006633 RID: 26163 RVA: 0x0022B650 File Offset: 0x00229850
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(IgnoreRequest other)
		{
		}

		// Token: 0x06006634 RID: 26164 RVA: 0x0022B660 File Offset: 0x00229860
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006635 RID: 26165 RVA: 0x0022B670 File Offset: 0x00229870
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006636 RID: 26166 RVA: 0x0022B680 File Offset: 0x00229880
		[MethodImpl(MethodImplOptions.NoInlining)]
		static IgnoreRequest()
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
					default:
						return;
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 != 0)
						{
							num2 = 1;
						}
						break;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						goto IL_C1;
					case 4:
						IgnoreRequest._parser = new MessageParser<IgnoreRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
				IL_C1:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
			}
		}

		// Token: 0x06006637 RID: 26167 RVA: 0x0022B768 File Offset: 0x00229968
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wJi0nBJfWg2VxmkkQ12U()
		{
			return true;
		}

		// Token: 0x06006638 RID: 26168 RVA: 0x0022B770 File Offset: 0x00229970
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IgnoreRequest nh8dOqJfhLJXrDooZ8wi()
		{
			return null;
		}

		// Token: 0x040023E2 RID: 9186
		private static readonly MessageParser<IgnoreRequest> _parser;

		// Token: 0x040023E3 RID: 9187
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023E4 RID: 9188
		public const int PlayerSearchFieldNumber = 1;

		// Token: 0x040023E5 RID: 9189
		private PlayerSearch playerSearch_;

		// Token: 0x040023E6 RID: 9190
		private static IgnoreRequest G63EyYJfLnuBZfCjfyVJ;
	}
}
